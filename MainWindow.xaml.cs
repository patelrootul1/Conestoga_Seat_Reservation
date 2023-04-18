using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Text.RegularExpressions;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

namespace Assignment3_SeatReservation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        //creating constant filename
        const string filename = "seatarrangement.xml";
        //Creating a list of seat class
        List<Seat> Seats = new List<Seat> { };
        List<Seat> DeserializedSeats = new List<Seat> { };
        List<Seat> sortedCityNames = new List<Seat> { };
        // Creating Objects of all seats 
        Seat a1 = new Seat();
        Seat a2 = new Seat();
        Seat a3 = new Seat();
        Seat a4 = new Seat();
        Seat b1 = new Seat();
        Seat b2 = new Seat();
        Seat b3 = new Seat();
        Seat b4 = new Seat();
        Seat c1 = new Seat();
        Seat c2 = new Seat();
        Seat c3 = new Seat();
        Seat c4 = new Seat();
        Seat d1 = new Seat();
        Seat d2 = new Seat();
        Seat d3 = new Seat();
        Seat d4 = new Seat();
        //Variable for fetching seat from combobox
        public string SeatNumberForXaml = "";
        // Counter for every seat which will help in determining if seat is reserved or not
        int A1counter = 0;
        int A2counter = 0;
        int A3counter = 0;
        int A4counter = 0;
        int B1counter = 0;
        int B2counter = 0;
        int B3counter = 0;
        int B4counter = 0;
        int C1counter = 0;
        int C2counter = 0;
        int C3counter = 0;
        int C4counter = 0;
        int D1counter = 0;
        int D2counter = 0;
        int D3counter = 0;
        int D4counter = 0;


        public MainWindow()
        {
            InitializeComponent();

        }
        //Event handler for ComboBox which will help in fetching seats
        private void SeatCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox seatNum = (ComboBox)sender;
            ComboBoxItem selectedCombo = (ComboBoxItem)seatNum.SelectedItem;
            SeatNumberForXaml = selectedCombo.Content.ToString();   
        }
        //Event handler for reserve button
        private void reserve_Click(object sender, RoutedEventArgs e)
        {
            //Variable to get the name of user
            String InputName = NameTextbox.Text.ToString();
            //Checking if name is not empty
            if (InputName != "")
            {
                //Validating name using regex
                if (!Regex.Match(InputName, "^[a-zA-Z]*$").Success)
                {
                    MessageBox.Show("Entered Name is not valid");
                }
                else
                {
                    switch (SeatNumberForXaml)
                    {

                        case "A1":
                            //checking if the seat is already booked
                            if (A1counter > 0)
                            {
                                
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                //storing the name of the label
                                a1.Name = InputName;
                                //storing the seatNumber of the label
                                a1.SeatNumber = SeatNumberForXaml;
                                //adding the object to seat list
                                Seats.Add(a1);
                                // changing background color
                                A1Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                //changing the name of seat to user input name
                                A1.Text = a1.Name;
                                //emptying the textbox
                                NameTextbox.Text = "";
                                //incrementing counter so that the seat can't be booked two times
                                A1counter++;
                                break;
                            }
                            //following the same for every seat
                        case "A2":
                            if (A2counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                a2.Name = InputName;
                                a2.SeatNumber = SeatNumberForXaml;
                                Seats.Add(a2);
                                A2Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                A2.Text = a2.Name;
                                NameTextbox.Text = "";
                                A2counter++;
                                break;
                            }
                        case "A3":
                            if (A3counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                a3.Name = InputName;
                                a3.SeatNumber = SeatNumberForXaml;
                                Seats.Add(a3);
                                A3Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                A3.Text = a3.Name;
                                NameTextbox.Text = "";
                                A3counter++;
                                break;
                            }
                        case "A4":
                            if (A4counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                a4.Name = InputName;
                                a4.SeatNumber = SeatNumberForXaml;
                                Seats.Add(a4);
                                A4Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                A4.Text = a4.Name;
                                NameTextbox.Text = "";
                                A4counter++;
                                break;
                            }
                        case "B1":
                            if (B1counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                b1.Name = InputName;
                                b1.SeatNumber = SeatNumberForXaml;
                                Seats.Add(b1);
                                B1Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                B1.Text = b1.Name;
                                NameTextbox.Text = "";
                                B1counter++;
                                break;
                            }
                        case "B2":
                            if (B2counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                b2.Name = InputName;
                                b2.SeatNumber = SeatNumberForXaml;
                                Seats.Add(b2);
                                B2Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                B2.Text = b2.Name;
                                NameTextbox.Text = "";
                                B2counter++;
                                break;
                            }
                        case "B3":
                            if (B3counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                b3.Name = InputName;
                                b3.SeatNumber = SeatNumberForXaml;
                                Seats.Add(b3);
                                B3Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                B3.Text = b3.Name;
                                NameTextbox.Text = "";
                                B3counter++;
                                break;
                            }
                        case "B4":
                            if (B4counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                b4.Name = InputName;
                                b4.SeatNumber = SeatNumberForXaml;
                                Seats.Add(b4);
                                B4Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                B4.Text = b4.Name;
                                NameTextbox.Text = "";
                                B4counter++;
                                break;
                            }
                        case "C1":
                            if (C1counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                c1.Name = InputName;
                                c1.SeatNumber = SeatNumberForXaml;
                                Seats.Add(c1);
                                C1Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                C1.Text = c1.Name;
                                NameTextbox.Text = "";
                                C1counter++;
                                break;
                            }
                        case "C2":
                            if (C2counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                c2.Name = InputName;
                                c2.SeatNumber = SeatNumberForXaml;
                                Seats.Add(c1);
                                C2Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                C2.Text = c2.Name;
                                NameTextbox.Text = "";
                                C2counter++;
                                break;
                            }
                        case "C3":
                            if (C3counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                c3.Name = InputName;
                                c3.SeatNumber = SeatNumberForXaml;
                                Seats.Add(c3);
                                C3Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                C3.Text = c3.Name;
                                NameTextbox.Text = "";
                                C3counter++;
                                break;
                            }
                        case "C4":
                            if (C4counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                c4.Name = InputName;
                                c4.SeatNumber = SeatNumberForXaml;
                                Seats.Add(c4);
                                C4Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                C4.Text = c4.Name;
                                NameTextbox.Text = "";
                                C4counter++;
                                break;
                            }
                        case "D1":
                            if (D1counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                d1.Name = InputName;
                                d1.SeatNumber = SeatNumberForXaml;
                                Seats.Add(d1);
                                D1Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                D1.Text = d1.Name;
                                NameTextbox.Text = "";
                                D1counter++;
                                break;
                            }
                        case "D2":
                            if (D2counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                d2.Name = InputName;
                                d2.SeatNumber = SeatNumberForXaml;
                                Seats.Add(d2);
                                D2Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                D2.Text = d2.Name;
                                NameTextbox.Text = "";
                                D2counter++;
                                break;
                            }
                        case "D3":
                            if (D3counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                d3.Name = InputName;
                                d3.SeatNumber = SeatNumberForXaml;
                                Seats.Add(d3);
                                D3Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                D3.Text = d3.Name;
                                NameTextbox.Text = "";
                                D3counter++;
                                break;
                            }
                        case "D4":
                            if (D4counter > 0)
                            {
                                MessageBox.Show("This seat is already Reserved!");
                                break;
                            }
                            else
                            {
                                d4.Name = InputName;
                                d4.SeatNumber = SeatNumberForXaml;
                                Seats.Add(d4);
                                D4Background.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                D4.Text = d4.Name;
                                NameTextbox.Text = "";
                                D4counter++;
                                break;
                            }
                        default:
                            MessageBox.Show("Please select valid Seat Number");
                            break;
                    }
                }

            }
            //Checking if all the seats are reserved
            else if (Seats.Count == 16)
            {
                MessageBox.Show("All Seats are Reserved!");

            }
            //condition for empty name
            else
            {
                MessageBox.Show("Please Enter Valid Name!");
            }


        }
        //Event handler for delete button
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            //variable for taking the name from user
            string inputName = NameTextbox.Text.ToString();
            //Checking if both the input are not empty
            if (inputName == "" && SeatNumberForXaml == "")
            {
                MessageBox.Show("Please Enter Name or Seat to delete reservation!");
            }
            //condition for deleting through seatnumber
            else if (inputName == "" && SeatNumberForXaml != "")
            {
                //Switching the seat number
                switch (SeatNumberForXaml)
                {
                    case "A1":
                        if (A1.Text != "")
                        {
                            Seats.Remove(a1);
                            A1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            A1.Text = "";
                            NameTextbox.Text = "";
                            A1counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }

                    case "A2":
                        if (A2.Text != "")
                        {
                            Seats.Remove(a2);
                            A2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            A2.Text = "";
                            NameTextbox.Text = "";
                            A2counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "A3":
                        if (A3.Text != "")
                        {
                            Seats.Remove(a3);
                            A3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            A3.Text = "";
                            NameTextbox.Text = "";
                            A3counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "A4":
                        if (A4.Text != "")
                        {
                            Seats.Remove(a4);
                            A4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            A4.Text = "";
                            NameTextbox.Text = "";
                            A4counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "B1":
                        if (B1.Text != "")
                        {
                            Seats.Remove(b1);
                            B1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            B1.Text = "";
                            NameTextbox.Text = "";
                            B1counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "B2":
                        if (B2.Text != "")
                        {
                            Seats.Remove(b2);
                            B2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            B2.Text = "";
                            NameTextbox.Text = "";
                            B2counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "B3":
                        if (B3.Text != "")
                        {
                            Seats.Remove(b3);
                            B3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            B3.Text = "";
                            NameTextbox.Text = "";
                            B3counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "B4":
                        if (B4.Text != "")
                        {
                            Seats.Remove(b4);
                            B4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            B4.Text = "";
                            NameTextbox.Text = "";
                            B4counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "C1":
                        if (C1.Text != "")
                        {
                            Seats.Remove(c1);
                            C1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            C1.Text = "";
                            NameTextbox.Text = "";
                            C1counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "C2":
                        if (C2.Text != "")
                        {
                            Seats.Remove(c2);
                            C2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            C2.Text = "";
                            NameTextbox.Text = "";
                            C2counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "C3":
                        if (C3.Text != "")
                        {
                            Seats.Remove(c3);
                            C3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            C3.Text = "";
                            NameTextbox.Text = "";
                            C3counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "C4":
                        if (C4.Text != "")
                        {
                            Seats.Remove(c4);
                            C4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            C4.Text = "";
                            NameTextbox.Text = "";
                            C4counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "D1":
                        if (D1.Text != "")
                        {
                            Seats.Remove(d1);
                            D1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            D1.Text = "";
                            NameTextbox.Text = "";
                            D1counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "D2":
                        if (D2.Text != "")
                        {
                            Seats.Remove(d2);
                            D2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            D2.Text = "";
                            NameTextbox.Text = "";
                            D2counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "D3":
                        if (D3.Text != "")
                        {
                            Seats.Remove(d3);
                            D3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            D3.Text = "";
                            NameTextbox.Text = "";
                            D3counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    case "D4":
                        if (D4.Text != "")
                        {
                            Seats.Remove(d4);
                            D4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                            D4.Text = "";
                            NameTextbox.Text = "";
                            D4counter = 0;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation Exist for deleting");
                            break;
                        }
                    default:
                        MessageBox.Show("Please Choose Correct seat Number or Name");
                        break;

                }

            }
            //condition for deleting through name
            else if (inputName != "" && SeatNumberForXaml != "")
            {
                if (A1.Text == inputName)
                {


                    Seats.Remove(a1);
                    A1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    A1.Text = "";
                    NameTextbox.Text = "";
                    A1counter = 0;
                }
                else if (A2.Text == inputName)
                {

                    Seats.Remove(a2);
                    A2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    A2.Text = "";
                    NameTextbox.Text = "";
                    A2counter = 0;
                }
                else if (A3.Text == inputName)
                {

                    Seats.Remove(a3);
                    A3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    A3.Text = "";
                    NameTextbox.Text = "";
                    A3counter = 0;


                }
                else if (A4.Text == inputName)
                {

                    Seats.Remove(a4);
                    A4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    A4.Text = "";
                    NameTextbox.Text = "";
                    A4counter = 0;


                }
                else if (B1.Text == inputName)
                {

                    Seats.Remove(b1);
                    B1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    B1.Text = "";
                    NameTextbox.Text = "";
                    B1counter = 0;


                }
                else if (B2.Text == inputName)
                {

                    Seats.Remove(b2);
                    B2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    B2.Text = "";
                    NameTextbox.Text = "";
                    B2counter = 0;


                }
                else if (B3.Text == inputName)
                {

                    Seats.Remove(b3);
                    B3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    B3.Text = "";
                    NameTextbox.Text = "";
                    B3counter = 0;


                }
                else if (B4.Text == inputName)
                {

                    Seats.Remove(b4);
                    B4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    B4.Text = "";
                    NameTextbox.Text = "";
                    B4counter = 0;


                }
                else if (C1.Text == inputName)
                {

                    Seats.Remove(c1);
                    C1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    C1.Text = "";
                    NameTextbox.Text = "";
                    C1counter = 0;


                }
                else if (C2.Text == inputName)
                {

                    Seats.Remove(c2);
                    C2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    C2.Text = "";
                    NameTextbox.Text = "";
                    C2counter = 0;


                }
                else if (C3.Text == inputName)
                {

                    Seats.Remove(c3);
                    C3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    C3.Text = "";
                    NameTextbox.Text = "";
                    C3counter = 0;


                }
                else if (C4.Text == inputName)
                {

                    Seats.Remove(c4);
                    C4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    C4.Text = "";
                    NameTextbox.Text = "";
                    C4counter = 0;


                }
                else if (D1.Text == inputName)
                {

                    Seats.Remove(d1);
                    D1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    D1.Text = "";
                    NameTextbox.Text = "";
                    D1counter = 0;


                }
                else if (D2.Text == inputName)
                {

                    Seats.Remove(d2);
                    D2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    D2.Text = "";
                    NameTextbox.Text = "";
                    D2counter = 0;


                }
                else if (D3.Text == inputName)
                {

                    Seats.Remove(d3);
                    D3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    D3.Text = "";
                    NameTextbox.Text = "";
                    D3counter = 0;

                }
                else if (D4.Text == inputName)
                {

                    Seats.Remove(d4);
                    D4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                    D4.Text = "";
                    NameTextbox.Text = "";
                    D4counter = 0;
                }
                // checking if the name is not matching
                else
                {
                    MessageBox.Show("The Given Name doesn't exist!");
                }
            }

        }
        //Event handler for clearing reservation
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            // checking if there are any booking available in the list using Any keyword
            if(Seats.Any())
            {
                //clearing the seats list and other list
                Seats.Clear();
                sortedCityNames.Clear();
                DeserializedSeats.Clear();
                linq.Content = "";
                NameTextbox.Text = "";
                //changing the color of all the seats to background
                A1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                A1.Text = "";
                A1counter = 0;

                A2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                A2.Text = "";
                A2counter = 0;

                A3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                A3.Text = "";
                A3counter = 0;

                A4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                A4.Text = "";
                A4counter = 0;

                B1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                B1.Text = "";
                B1counter = 0;

                B2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                B2.Text = "";
                B2counter = 0;

                B3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                B3.Text = "";
                B3counter = 0;

                B4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                B4.Text = "";
                B4counter = 0;

                C1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                C1.Text = "";
                C1counter = 0;

                C2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                C2.Text = "";
                C2counter = 0;

                C3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                C3.Text = "";
                C3counter = 0;

                C4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                C4.Text = "";
                C4counter = 0;

                D1Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                D1.Text = "";
                B1counter = 0;

                D2Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                D2.Text = "";
                D2counter = 0;

                D3Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                D3.Text = "";
                D3counter = 0;

                D4Background.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));
                D4.Text = "";
                D4counter = 0;
            }
            else
            {
                MessageBox.Show("No Reservation To clear");
            }
        }
        //Query for sorting from z to a
        private void linq1_Click(object sender, RoutedEventArgs e)
        {
            if (Seats.Any())
            {
                //using the OrderByDescending performing sorting from z to a
                string namesinlist = string.Empty;
                sortedCityNames = Seats.OrderByDescending(Name => Name).ToList();
                foreach (var se in sortedCityNames)
                {
                    namesinlist += se.Name;
                    namesinlist += System.Environment.NewLine;
                }
                linq.Content = namesinlist;
            }
            else
            {
                MessageBox.Show("No reservation to sort");
            }


        }
        //Query for sorting from shortest to longest
        private void linq2_Click(object sender, RoutedEventArgs e)
        {
            if (Seats.Any())
            {
                //using the OrderBy keyword performing sorting from shortest to longest
                string namesinlist = string.Empty;
                sortedCityNames = Seats.OrderBy(Name => Name.Name.Length).ToList();
                foreach (var se in sortedCityNames)
                {
                    namesinlist += se.Name;
                    namesinlist += System.Environment.NewLine;
                }
                linq.Content = namesinlist;
            }
            else
            {
                MessageBox.Show("No reservation to sort");
            }

        }
        //Query for checking unreserved seat
        private void linq3_Click(object sender, RoutedEventArgs e)
        {
            //creating a seat list and comparing it to the actual list of reservation removing the not equal values
            if (Seats.Any())
            {
                string namesinlist = string.Empty;
                List<string> seatslist = new List<string>
                {
                    "A1","A2","A3","A4",
                    "B1","B2","B3","B4",
                    "C1","C2","C3","C4",
                    "D1","D2","D3","D4"
                };
                foreach(var se in Seats)
                {
                    if(seatslist.Contains(se.SeatNumber))
                    {
                        seatslist.Remove(se.SeatNumber);
                    }
                }
                seatslist.Sort();
                foreach(var se in seatslist)
                {
                    namesinlist += se;
                    namesinlist += System.Environment.NewLine;
                }
                linq.Content = namesinlist;
            }
            else
            {
                MessageBox.Show("No reservation to sort");
            }

        }
        //button to serialize into xml document
        private void serialize_Click(object sender, RoutedEventArgs e)
        {
            if (Seats.Any())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Seat>));
                TextWriter writer = new StreamWriter(filename);
                serializer.Serialize(writer, Seats);
                writer.Close();
            }
            else
            {
                MessageBox.Show("There is no arrangement to save");
            }
        }
        //button to deserialize the xml document and print the file values.
        private void deserialize_Click(object sender, RoutedEventArgs e)
        {
            string namesinlist = string.Empty;
            namesinlist += "Name";
            namesinlist += "   ";
            namesinlist += "SeatNumber";
            namesinlist += System.Environment.NewLine;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Seat>));
            FileStream fs = new FileStream(filename, FileMode.Open);
            DeserializedSeats = (List<Seat>)serializer.Deserialize(fs);
            if (DeserializedSeats.Any())
            {
                foreach (var se in DeserializedSeats)
                {
                    namesinlist += se.Name;
                    namesinlist += "     ";
                    namesinlist += se.SeatNumber;
                    namesinlist += System.Environment.NewLine;
                }
                linq.Content = namesinlist;
            }
            else
            {
                MessageBox.Show("No reservation Exist");
            }
            fs.Close();
        }
    }
}
