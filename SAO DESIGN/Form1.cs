using MySql.Data.MySqlClient;
using System.Data;

namespace SAO_DESIGN
{
    public partial class Form1 : Form
    {
        string dbcon = "localhost";
        string mysqluser = "root";
        string mysqlpassword = "";
        string dbname = "studentdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IDInput.Enter += new EventHandler(IDInput_Enter);
            IDInput.Leave += new EventHandler(IDInput_Leave);
            IDInput_SetText();

        }

        protected void IDInput_SetText()
        {
            this.IDInput.Text = "Enter Student ID";
            IDInput.ForeColor = Color.Gray;
        }

        private void IDInput_Enter(object sender, EventArgs e)
        {
            if (IDInput.ForeColor == Color.Black)
                return;
            IDInput.Text = "";
            IDInput.ForeColor = Color.Black;
        }
        private void IDInput_Leave(object sender, EventArgs e)
        {
            if (IDInput.Text.Trim() == "")
                IDInput_SetText();
        }
        private void student1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void IDInputBTN_Click(object sender, EventArgs e)
        {
            string conString = "server=" + dbcon + ";uid=" + mysqluser + ";pwd=" + mysqlpassword + ";database=" + dbname;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            try
            {
                string loadtable = "SELECT concat(b.LastName, ' ', b.FirstName) AS 'Student Name', a.violation_name AS 'Violations', a.timestamp AS 'Time Stamp' FROM violations AS a LEFT JOIN students as b ON a.sid = b.sid where a.sid = " + IDInput.Text;
                MySqlCommand cmd = new MySqlCommand(loadtable, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                StudentInfoDataGrid.DataSource = dt;
                this.StudentInfoDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.StudentInfoDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.StudentInfoDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                try
                {
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandText = "SELECT FirstName,LastName,SID,studentimage FROM students WHERE SID = " + IDInput.Text;
                    MySqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        StudentName.Text = "Name: " + reader.GetString(0) + " " + reader.GetString(1);
                        StudentNumber.Text = "Student ID: " + reader.GetString(2);
                        byte[] imageBytes = Convert.FromBase64String(reader.GetString(3));
                        using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                        {
                            StudentPhoto.Image = Image.FromStream(ms, true);
                            StudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void CheckDB_Click(object sender, EventArgs e)
        {
            string conString = "server=" + dbcon + ";uid=" + mysqluser + ";pwd=" + mysqlpassword + ";database=" + dbname;
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                con.Open();
                MessageBox.Show("Connection Open!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
        }

        private void StudentInfoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void attendance_Click(object sender, EventArgs e)
        {
            string conString = "server=" + dbcon + ";uid=" + mysqluser + ";pwd=" + mysqlpassword + ";database=" + dbname;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            try
            {
                string loadtable = "SELECT concat(b.LastName, ' ', b.FirstName) AS 'Student Name', a.time_in AS 'Time In' FROM attendance AS a LEFT JOIN students as b ON a.sid = b.sid where a.sid = " + IDInput.Text;
                MySqlCommand cmd = new MySqlCommand(loadtable, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                StudentInfoDataGrid.DataSource = dt;
                this.StudentInfoDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.StudentInfoDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                try
                {
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandText = "SELECT FirstName,LastName,SID,studentimage FROM students WHERE SID = " + IDInput.Text;
                    MySqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        StudentName.Text = "Name: " + reader.GetString(0) + " " + reader.GetString(1);
                        StudentNumber.Text = "Student ID: " + reader.GetString(2);
                        byte[] imageBytes = Convert.FromBase64String(reader.GetString(3));
                        using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                        {
                            StudentPhoto.Image = Image.FromStream(ms, true);
                            StudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
