/*
using System;
using System.Windows;
using MySql.Data.MySqlClient;

namespace negosud.db._modelFamily
{
    internal class FamilyModel
    {
        Model con = new Model();
        MySqlCommand? command;

        public void Select(int id)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Select * from family where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getName = reader.GetString("name");

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
                command = new MySqlCommand("Select * from family", con.cn);
                command.ExecuteNonQuery();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getName = reader.GetString("name");

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
        public void Add(string name)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Insert into family ( name ) VALUES ( '" + name + "' )", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Ligne Ajoutée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Edit(int id, string name)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Update family set name = '" + name + "' where id = '" + id + "'", con.cn);
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
                command = new MySqlCommand("Delete from family where id = '" + id + "'", con.cn);
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