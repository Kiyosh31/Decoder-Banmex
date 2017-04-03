﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banmex.Menu
{
    public partial class ModifyClient : Form
    {
        Class.Connection Connection;
        string idClient;

        public ModifyClient(Class.Connection Connection, string idClient)
        {
            InitializeComponent();

            this.Connection = Connection;
            this.idClient = idClient;

            idTextBox.Enabled = false;
        }

        private void ModifyClient_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class.Client client = Class.Client.searchClient(Connection.myConnection, idClient);
            idTextBox.Text = Convert.ToString(client.IdClient);
            firstNameTextBox.Text = client.FirstName;
            lastNameTextBox.Text = client.LastName;
            phoneTextbox.Text = Convert.ToString(client.Phone);
            rfcTextBox.Text = client.Rfc;
            Connection.CloseConnection();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || phoneTextbox.Text == "" || rfcTextBox.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                Class.Client client = new Class.Client(int.Parse(idClient), firstNameTextBox.Text, lastNameTextBox.Text, Int32.Parse(phoneTextbox.Text), rfcTextBox.Text);
                Class.Client.modifyClient(Connection.myConnection, client);
                Connection.CloseConnection();

                MessageBox.Show("Modificado exitosamente");
                this.Close();
            }
        }
    }
}
