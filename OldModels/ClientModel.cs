/*
using System;
using System.Windows;
using MySql.Data.MySqlClient;

namespace negosud.db._modelClient
{
    internal class ClientModel
    {
        Model con = new Model();
        MySqlCommand? command;

        public void Select(int id)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Select * from client where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getLname = reader.GetString("lname");
                        var getFname = reader.GetString("fname");
                        var getMail = reader.GetString("mail");
                        var getPhone = reader.GetInt32("phone");
                        var getBillingAddress = reader.GetString("billingAddress");
                        var getDelivryAddress = reader.GetString("delivryAddress");

                        MessageBox.Show(getId + ""); // affiche l'id de tous les articles
                    }
                }

                con.cn.Close();
                MessageBox.Show("Lignes Récuperés");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectAll()
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select * from client", con.cn);
                command.ExecuteNonQuery();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getLname = reader.GetString("lname");
                        var getFname = reader.GetString("fname");
                        var getMail = reader.GetString("mail");
                        var getPhone = reader.GetInt32("phone");
                        var getBillingAddress = reader.GetString("billingAddress");
                        var getDelivryAddress = reader.GetString("delivryAddress");

                        MessageBox.Show(getId + ""); // affiche l'id de tous les articles
                    }
                }

                con.cn.Close();
                MessageBox.Show("Lignes Récuperés");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Add(string lname, string fname, string mail, int phone, string billingAddress, string delivryAddress)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Insert into client ( lname, fname, mail, phone, billingAddress, delivryAddress ) VALUES ( '" + lname + "','" + fname + "','" + mail + "','" + phone + "','" + billingAddress + "','" + delivryAddress + "' )", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Ligne Ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Edit(int id, string lname, string fname, string mail, int phone, string billingAddress, string delivryAddress)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Update client set lname = '" + lname + "',fname = '" + fname + "',mail = '" + mail + "',phone = '" + phone + "',billingAddress = '" + billingAddress + "',delivryAddress = '" + delivryAddress + "' where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Ligne mis à jour");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Delete from client where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Ligne supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
*/