﻿using Charity_Managment_System.Models;

namespace Charity_Managment_System
{
    interface IDBLayer
    {
        //Connection Control
        void InitializeConnection();
        void TerminateConnection();
        //Get All....
        Person[] GetAllPersons();
        Employee[] GetAllEmployees();
        Donor[] GetAllDonors();
        Volunteer[] GetAllVolunteers();
        Recepient[] GetAllRecepients();
        Beneficiary[] GetAllBeneficiaries();
        Department[] GetAllDepartments();
        Campaign[] GetAllCampaigns();
        Item[] GetAllItems();
        MainCategory[] GetAllMainCategories();
        SubCategory[] GetAllSubCategories();
        Category[] GetAllCategories();
        //Employee
        Employee[] GetEmployeesWorkingIn(Department department);
        Employee[] GetEmployeesManaging(Campaign campaign);
        //Donor
        Donor[] GetDonorsDonatingTo(Campaign campaign);
        DonorItem[] GetDonorsOf(Campaign campaign, Item item);
        //Volunteer
        Volunteer[] GetVolunteersOf(Campaign campaign);
        //Recepient
        Recepient[] GetRecepientsReceivingFrom(Campaign campaign);
        RecepientItem[] GetRecepientsOf(Campaign campaign, Item item);
        //Beneficiary
        Beneficiary[] GetBeneficiariesOf(Campaign campaign);
        //Item
        Item[] GetItemsReceivedBy(Recepient recepient);
        Item[] GetItemsDonatedBy(Donor donor);
        Item[] GetItemsIn(Campaign campaign);
        Item[] GetItemsOf(MainCategory mainCategory);
        Item[] GetItemsOf(MainCategory mainCategory, SubCategory subCategory);
        //Department
        Department[] GetDepartmentsInWhich(Employee employee);
    }
}