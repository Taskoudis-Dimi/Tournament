using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibraryVD;
using TrackerLibraryVD.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;



        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;

            // CreateSampleData();

            WireUpLists();
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Smith" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Jim", LastName = "Green" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Tom", LastName = "Grifith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Leo", LastName = "Trotzki" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";



        }

        private void addNewMemberLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            //if (emailValue.Text.Length == 0)
            //{
            //    return false;
            //}
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                //p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);

                WireUpLists();


                firstNameValue.Text = "";
                lastNameValue.Text = "";
                //emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill all fields.");
            }
        }

        private void CreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);
            callingForm.TeamComplete(t);
            this.Close();

        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }


        }
    }
}
