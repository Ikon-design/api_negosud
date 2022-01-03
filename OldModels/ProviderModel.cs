/*
using System;
using System.Windows;
using MySql.Data.MySqlClient;

namespace negosud.db._modelProvider
{
    internal class ProviderModel
    {
        Model con = new Model();
        MySqlCommand? command;
        public void Select(int id)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Select * from provider where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getContactId = reader.GetInt32("contactId");
                        var getName = reader.GetString("name");
                        var getAddress = reader.GetString("address");
                        var getSiret = reader.GetString("siret");

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
                command = new MySqlCommand("Select * from provider", con.cn);
                command.ExecuteNonQuery();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getContactId = reader.GetInt32("contactId");
                        var getName = reader.GetString("name");
                        var getAddress = reader.GetString("address");
                        var getSiret = reader.GetString("siret");

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
        public void Add(int contactId, string name, string address, string siret)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Insert into provider ( contactId, name, address, siret ) VALUES ( '" + contactId + "', '" + name + "', '" + address + "', '" + siret + "' )", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Ligne Ajoutée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Edit(int id, int clientOrderId, int articleId, int quantity)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Update provider set clientOrderId = '" + clientOrderId + "',articleId = '" + articleId + "',quantity = '" + quantity + "' where id = '" + id + "'", con.cn);
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
                command = new MySqlCommand("Delete from provider where id = '" + id + "'", con.cn);
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