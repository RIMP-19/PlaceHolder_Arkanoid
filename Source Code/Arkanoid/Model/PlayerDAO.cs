using Arkanoid.Controller;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Arkanoid.Model
{
    public static class PlayerDAO
    {

        public static void CreateNew(Player player)
        {

            string[] sql = new string[3] { "", "", "" };

            sql[0] = $"SELECT COUNT(1) FROM high_scores WHERE player = '{player.UserName}';";

            sql[1] = $"INSERT INTO high_scores (player, score) " +
                $"VALUES ('{player.UserName}',{player.Score});";

            sql[2] = $"UPDATE high_scores SET score =" +
                $" {player.Score} WHERE player = '{player.UserName}';";

            try
            {
                var dt = DataBaseConnection.ExecuteQuery(sql[0]);

                if (dt.Rows[0][0].ToString() == "1")
                    DataBaseConnection.ExecuteNonQuery(sql[2]);
                else
                    DataBaseConnection.ExecuteNonQuery(sql[1]);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("An error has occured in the database.\n" + ex.Message,
                    "Server Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }

        }

        public static List<Player> GetTop10()
        {
            var top10 = new List<Player>();

            var sql = "SELECT * FROM high_scores ORDER BY score DESC FETCH FIRST 10 ROWS ONLY";
            try
            {
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

                if (top10.Count < 10)
                {
                    for (int i = top10.Count + 1; i <= 10; i++)
                    {
                        var p = new Player
                        {
                            UserName = "-----",
                            Score = 0
                        };
                        top10.Add(p);
                    }
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("An error has occured in the database.\n" + ex.Message,
                    "Server Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }

            return top10;
        }

    }
}
