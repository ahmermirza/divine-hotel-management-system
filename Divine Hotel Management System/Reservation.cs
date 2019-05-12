﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divine_Hotel_Management_System
{
    class Reservation
    {
        public int ReservationId;
        public int GuestId;
        public int RoomTypeId;
        public DateTime CheckinDate;
        public DateTime CheckoutDate;
        public string NumberOfPeople;
        public int TotalAmount;

        public string conString = "Server=LENOVO-PC\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Reservation()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }

        public DataTable ListAll()
        {
            DataTable reservationsDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM reservations";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(reservationsDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return reservationsDT;
        }

        public Reservation Get(int reservationId)
        {
            string queryString = "SELECT * FROM reservations WHERE reservation_ID = '" + reservationId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable reservationsDT = new DataTable();
            sqlDA.Fill(reservationsDT);

            GuestId = int.Parse(reservationsDT.Rows[0]["guest_ID"].ToString().Trim());
            RoomTypeId = int.Parse(reservationsDT.Rows[0]["room_type_ID"].ToString().Trim());
            CheckinDate = DateTime.Parse(reservationsDT.Rows[0]["checkin_date"].ToString().Trim());
            CheckoutDate = DateTime.Parse(reservationsDT.Rows[0]["checkout_date"].ToString().Trim());
            NumberOfPeople = reservationsDT.Rows[0]["number_of_people"].ToString().Trim();
            TotalAmount = int.Parse(reservationsDT.Rows[0]["total_amount"].ToString().Trim());

            return this;
        }
        public DataTable GuestsComboBox()
        {
            DataTable guestDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM guests";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(guestDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return guestDT;
        }

        public DataTable RoomTypeComboBox()
        {
            DataTable roomTypeDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM room_types";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(roomTypeDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return roomTypeDT;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO reservations (guest_ID, room_type_ID, checkin_date, checkout_date, number_of_people, total_amount) VALUES('" + GuestId + "','" + RoomTypeId + "', '" + CheckinDate + "', '" + CheckoutDate + "','" + NumberOfPeople + "','" + TotalAmount + "')";

            SqlCommand sqlCom = new SqlCommand(queryString, sqlCon);
            try
            {
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(int reservationId)
        {
            string queryString = "DELETE FROM reservations WHERE reservation_ID = '" + reservationId + "'";

            SqlCommand sqlCom = new SqlCommand(queryString, sqlCon);
            try
            {
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Update(int reservationId)
        {
            string queryString = "UPDATE reservations SET guest_ID = '" + GuestId + "', room_type_ID = '" + RoomTypeId + "', checkin_date = '" + CheckinDate + "', checkout_date = '" + CheckoutDate + "', number_of_people = '" + NumberOfPeople + "', total_amount = '" + TotalAmount + "' WHERE reservation_ID = '" + reservationId + "'";

            SqlCommand sqlCom = new SqlCommand(queryString, sqlCon);
            try
            {
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void CloseConnection()
        {
            sqlCon.Close();
        }
    }
}
