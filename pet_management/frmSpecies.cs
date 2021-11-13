﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace pet_management
{
    public partial class frmSpecies : Form
    {
        EntityState state = EntityState.Unchaged;
        public frmSpecies()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            InitializeControl();
        }

        private void InitializeControl()
        {
            btnAdd.Enable();
            btnUpdate.Disable();
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtDescription.ReadOnly = true;
        }

        private void LoadData()
        {
            speciesBindingSource.DataSource = SpeciesBUS.GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnUpdate.Enable();
            btnAdd.Disable();
            resetInput();
            speciesBindingSource.Add(new Species());
            speciesBindingSource.MoveLast();
            state = EntityState.Added;
            txtId.Text = (SpeciesBUS.GetLastID() + 1).ToString();
            txtDescription.ReadOnly = false;
            txtName.ReadOnly = false;
            txtName.Focus();
        }

        private void resetInput()
        {
            txtName.Text = null;
            txtDescription.Text = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            speciesBindingSource.EndEdit();
            Species species = speciesBindingSource.Current as Species;
            if (species != null)
            {
                if (state == EntityState.Added)
                {
                    bool isSuccess = SpeciesBUS.AddNewSpecies(species);
                }
                else if (state == EntityState.Changed)
                {
                    SpeciesBUS.Update(species);
                }
            }
            
            grcDemo.Refresh();
            lytInput.Disable();
            state = EntityState.Unchaged;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            speciesBindingSource.RemoveCurrent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            state = EntityState.Changed;
            lytInput.Enable();
            txtName.ReadOnly = false;
            txtDescription.ReadOnly = false;
            btnUpdate.Enable();
            txtName.Focus();
        }
    }
}
