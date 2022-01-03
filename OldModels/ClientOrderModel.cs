/*
using System;
using System.Windows;
using MySql.Data.MySqlClient;

namespace negosud.db._modelClientOrder
{
    internal class ClientOrderModel
    {
        Model con = new Model();
        MySqlCommand? command;

        public void Select(int id)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Select * from clientorder where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getClientId = reader.GetInt32("clientId");
                        var getReference = reader.GetString("reference");
                        var getPurchaseDate = reader.GetString("purchaseDate");
                        var getDelivryDate = reader.GetString("delivryDate");
                        var getReceivedDate = reader.GetString("receivedDate");

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
                command = new MySqlCommand("Select * from clientorder", con.cn);
                command.ExecuteNonQuery();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getClientId = reader.GetInt32("clientId");
                        var getReference = reader.GetString("reference");
                        var getPurchaseDate = reader.GetString("purchaseDate");
                        var getDelivryDate = reader.GetString("delivryDate");
                        var getReceivedDate = reader.GetString("receivedDate");

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
        public void Add(int clientId, string reference, string purchaseDate, string delivryDate, string receivedDate)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Insert into clientorder ( clientId, reference, purchaseDate, delivryDate, receivedDate ) VALUES ( '" + clientId + "','" + reference + "','" + purchaseDate + "','" + delivryDate + "','" + receivedDate + "' )", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Ligne Ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Edit(int id, int clientId, string reference, string purchaseDate, string delivryDate, string receivedDate)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Update clientorder set clientId = '" + clientId + "',reference = '" + reference + "',purchaseDate = '" + purchaseDate + "',delivryDate = '" + delivryDate + "',receivedDate = '" + receivedDate + "' where id = '" + id + "'", con.cn);
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