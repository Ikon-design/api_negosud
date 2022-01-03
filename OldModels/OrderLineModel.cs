/*
using System;
using System.Windows;
using MySql.Data.MySqlClient;

namespace negosud.db._modelOrderLine
{
    internal class OrderLineModel
    {
        Model con = new Model();
        MySqlCommand? command;

        public void Select(int id)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Select * from orderline where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getClientOrderId = reader.GetInt32("clientOrderId");
                        var getArticleId = reader.GetInt32("articleId");
                        var getQuantity = reader.GetInt32("quantity");

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
                command = new MySqlCommand("Select * from orderline", con.cn);
                command.ExecuteNonQuery();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getClientOrderId = reader.GetInt32("clientOrderId");
                        var getArticleId = reader.GetInt32("articleId");
                        var getQuantity = reader.GetInt32("quantity");

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
        public void Add(int clientOrderId, int articleId, int quantity)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Insert into orderline ( clientOrderId, articleId, quantity ) VALUES ( '" + clientOrderId + "', '" + articleId + "', '" + quantity + "' )", con.cn);
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
                command = new MySqlCommand("Update family set clientOrderId = '" + clientOrderId + "',articleId = '" + articleId + "',quantity = '" + quantity + "' where id = '" + id + "'", con.cn);
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
                command = new MySqlCommand("Delete from clientOrderId where id = '" + id + "'", con.cn);
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