using Arkanoid.Controller;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arkanoid.Modelo
{
    public static class PlayerDAO
    {

        public static void CreateNew(Player player)
        {
            var sql = $"INSERT INTO high_scores (name, score) " +
                $"VALUES ('{player.UserName}',{player.Score})";

            try
            {
                DataBaseConnection.ExecuteNonQuery(sql);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("An error has occured in the database.\n" + ex.Message,
                    "Server Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }

        }
        public static List<Player> GetTop10()
        {
            var top10 = new List<Player>();

            var sql = "SELECT name, score FROM high_scores ORDER BY score DESC FETCH FIRST 10 ROWS ONLY";

            var dt = DataBaseConnection.ExecuteQuery(sql);

            foreach (DataRow row in dt.Rows)
            {
                var p = new Player
                {
                    UserName = row[0].ToString(),
                    Score = Convert.ToInt32(row[1].ToString())
                };
                top10.Add(p);
            }

            return top10;
        }

    }
}
