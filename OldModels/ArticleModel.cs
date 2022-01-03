/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using MySql.Data.MySqlClient;

namespace negosud.db._modelArticle
{
    internal class ArticleModel
    {
        Model con = new Model();
        MySqlCommand? command;

        public void Select(int id)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Select * from article where id = '" + id + "'", con.cn);
                command.ExecuteNonQuery();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getFamilyId = reader.GetString("familyId");
                        var getName = reader.GetString("name");
                        var getDescription = reader.GetString("description");
                        var getDate = reader.GetInt32("date");
                        var getUnitPrice = reader.GetInt32("unitPrice");
                        var getGroupPrice = reader.GetInt32("groupPrice");
                        var getReference = reader.GetInt32("reference");
                        var getStockedQuantity = reader.GetInt32("stockedQuantity");
                        var getStockagePosition = reader.GetString("positionPosition");

                        MessageBox.Show(getName); // affiche le nom de l'article avec l'id associé
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
                command = new MySqlCommand("Select * from article", con.cn);
                command.ExecuteNonQuery();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var getId = reader.GetInt32("id");
                        var getFamilyId = reader.GetString("familyId");
                        var getName = reader.GetString("name");
                        var getDescription = reader.GetString("description");
                        var getDate = reader.GetInt32("date");
                        var getUnitPrice = reader.GetInt32("unitPrice");
                        var getGroupPrice = reader.GetInt32("groupPrice");
                        var getReference = reader.GetString("reference");
                        var getStockedQuantity = reader.GetInt32("stockedQuantity");
                        var getStockagePosition = reader.GetString("stockagePosition");

                        MessageBox.Show(getId + ""); // affiche le nom de tous les articles
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
        public void Add(int familyId, int providerId, string name, string description, int date, int unitPrice, int groupPrice, string reference, int stockedQuantity, string stockagePosition)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Insert into article ( familyId, providerId, name, description, date, unitPrice, groupPrice, reference, stockedQuantity, stockagePosition ) VALUES ( '" + familyId + "','" + providerId + "','" + name + "','" + description + "','" + date + "','" + unitPrice + "','" + groupPrice + "','" + reference + "','" + stockedQuantity + "','" + stockagePosition + "' )", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Ligne Ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Edit(int id, int familyId, int providerId, string name, string description, int date, int unitPrice, int groupPrice, string reference, int stockedQuantity, string stockagePosition)
        {
            try
            {
                con.cn.Close(); 
                con.cn.Open();
                command = new MySqlCommand("Update article set familyId = '" + familyId + "',providerId = '" + providerId + "',name = '" + name + "',description = '" + description + "',date = '" + date + "',unitPrice = '" + unitPrice + "',groupPrice = '" + groupPrice + "',reference = '" + reference + "',stockedQuantity = '" + stockedQuantity + "',stockagePosition = '" + stockagePosition + "' where id = '" + id + "'", con.cn);
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
                command = new MySqlCommand("Delete from article where id = '" + id + "'", con.cn);
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