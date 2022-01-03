/*
using System;
using System.Windows;
using MySql.Data.MySqlClient;

namespace negosud.db._modelContact
{
    internal class ContactModel
    {
        Model con = new Model();
        MySqlCommand? command;

        public void Select(int id)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Select * from contact where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getLname = reader.GetInt32("lname");
                        var getFname = reader.GetString("fname");
                        var getMail = reader.GetString("mail");
                        var getPhone = reader.GetString("phone");

                        MessageBox.Show(getId + ""); // affiche l'id de tous les articles
                    }
                }

                con.cn.Close();
                MessageBox.Show("Lignes Récuperées");
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
                command = new MySqlCommand("Select * from clientorder", con.cn);
                command.ExecuteNonQuery();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getLname = reader.GetInt32("lname");
                        var getFname = reader.GetString("fname");
                        var getMail = reader.GetString("mail");
                        var getPhone = reader.GetString("phone");

                        MessageBox.Show(getId + ""); // affiche l'id de tous les articles
                    }
                }

                con.cn.Close();
                MessageBox.Show("Lignes Récuperées");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Add(string lname, string fname, string mail, int phone)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Insert into clientorder ( lname, fname, mail, phone ) VALUES ( '" + lname + "','" + fname + "','" + mail + "','" + phone + "' )", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Ligne Ajoutée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Edit(int id, string lname, string fname, string mail, int phone)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Update clientorder set lname = '" + lname + "',fname = '" + fname + "',mail = '" + mail + "',phone = '" + phone + "' where id = '" + id + "'", con.cn);
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
                command = new MySqlCommand("Delete from clientorder where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Ligne supprimée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
*/