using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7Hide_and_Seek
{
    public partial class Form1 : Form
    {
        int Moves;

        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            CreateObject();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        /// <summary>
        /// 初始化各个房间以及房子的格局
        /// </summary>
        private void CreateObject()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "inside the closet", "an oak door with a brass knob");
            diningRom = new RoomWithHidingPlace("Dining Room", "a crystal chandelier", "in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen", "a screen door");
            stairs = new Room("Stairs","a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet","in the shower");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a large bed", "under the bed");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");

            diningRom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRom };
            kitchen.Exits = new Location[] { diningRom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        /// <summary>
        ///找到人后显示胜利窗口并重新绘制窗口使其可以重新开始躲藏 
        /// </summary>
        /// <param name="displayMessage"></param>
        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "You found your opponent in " + Moves +
                    " moves! He was hiding " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }

        /// <summary>
        /// 进入另一个房间，并增加步数，显示下一个房间的信息
        /// </summary>
        /// <param name="newLocation"></param>
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        /// <summary>
        /// 显示当前房间的信息并显示当前步数，如果当前房间有藏身的地方，显示检查按钮，如果有门，显示走出按钮
        /// </summary>
        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;

            description.Text = currentLocation.Description + "\r\n(move #" + Moves + ")";

            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Check " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        /// <summary>
        /// 点击按钮，移动到选择的地方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        /// <summary>
        /// 点击按钮，移动到有门连通的另一边
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        /// <summary>
        /// 点击按钮，检查藏身地方，增加步数，如果有人则弹出结束游戏的窗口，如果没人，更新窗口显示的步数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        /// <summary>
        /// 点击躲避按钮，隐藏此按钮，数10下，每数一下，人就移动一下，然后显示房间信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;

            for (int i = 0; i < 10; i++)
            {
                opponent.Move();
                description.Text = i + " ... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(700);
            }

            description.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
