### User Manual for the **Art of Beauty Festival Event Management System**

_Author: **[Chereese Bryant]**_ <br/>
_Version: **[V3]**_ <br/>
_Revised: **[05/01/2025]**_ <br/>
<small>Copyright (C)**[2025]**, <i>All rights reserved.</i></small>

# User Manual for the **Art of Beauty Festival Event Management SystemSystem**




# **Table of Contents**

1. [Introduction](#1-introduction)
2. [Major Features](#major-features)
   - [Feature One: Register Participants](#feature-one-register-participants)
   - [Feature Two: Role-Specific Data Collection](#feature-two-role-specific-data-collection)
   - [Feature Three: View and Filter Participants](#feature-three-view-and-filter-participants)
   - [Feature Four: Fee Calculation and Revenue Tracking](#feature-four-fee-calculation-and-revenue-tracking)
   - [Feature Five: XML Data Storage](#feature-five-xml-data-storage)
3. [Step-by-Step Guide](#step-by-step-guide)
   - [Using the Main Menu](#using-the-main-menu)
   - [Registering a Participant](#registering-a-participant)
   - [Viewing Participant Records](#viewing-participant-records)
   - [Filtering by Role or Year](#filtering-by-role-or-year)
   - [Calculating Total Fees](#calculating-total-fees)
4. [Troubleshooting](#troubleshooting)



---

## **1. Introduction**

The Power Tumbling Event Score-Tracking System is a scoring application designed for gymnastics or tumbling event coordinators. Its primary purpose is to capture scores, calculate averages, assign awards, and manage athlete data efficiently.

**Intended Users**:

- Event organizers for gymnastics competitions.
- Coaches and trainers who wish to track the team's performance records.
- Judges managing event scoring systems.

---

## **2. Major Features**


### **Feature One: Register Participants**

Users can register individuals as attendees, vendors, performers, or beauty artists. General information includes name, contact, role, and attendance days.

  

### **Feature Two: Role-Specific Data Collection**

Each role presents a custom set of inputs:

- Vendors provide business, booth, and product information.
- Food vendors include food category and certification details.
- Performers submit technical and background info.
- Beauty artists specify service type and licensing details.

  

### **Feature Three: View and Filter Participants**

All participant data is viewable in a grid with filter options by role and festival year.

  

### **Feature Four: Fee Calculation and Revenue Tracking**

Fees are calculated based on role and selected options (e.g., booth size). The system includes tools to calculate total fees collected.

  

### **Feature Five: XML Data Storage**

All participant data is saved to `participants.xml`. This file supports data persistence and can be reloaded on startup.

---

## **3. Step-by-Step Guide**

#### **Using the Main Menu**
 1. Launch the program. The main menu includes:
		- Register Participant
		- View Participants
		- Exit
 2. Click "Register Participant" to enter a new participant.
 3. Click "View Participants" to open the searchable grid.

#### **Registering a Participant**
1. Click "Register Participant".
2. Enter First and Last Name, Email, Phone.
3. Select Role (Attendee, Vendor, Performer, Beauty Artist).
4. Choose Attendance Days.
5. Fill out role-specific fields (e.g., Booth Size, Performance Type).
6. Click Register to save, or Cancel to discard.


#### **Viewing Participant Records**
1. Click "View Participants".
2. Review entries in the grid.
3. Use the Role and Year dropdowns to filter the table.


  #### **Filtering by Role or Year**
- Use the dropdowns at the top of the Participant List Form.
- Select "All" to remove filters.


  #### **Calculating Total Fees**

- Use the backend method `FestivalManager.CalculateTotalFees()` in code.
- Optionally expose via button to display total revenue.

---

## **4. Troubleshooting**


**Problem:** Role-specific fields not visible.
**Solution:** Ensure the Role ComboBox has a `SelectedIndexChanged` event wired up and GroupBoxes are visible for the selected role.

  
**Problem:** Participants not saved.
**Solution:** Ensure `participants.xml` is writable and properly set to “Copy if newer”.

  
**Problem:** XML file not found on load.
**Solution:** Confirm the path: `DataFiles/participants.xml` exists relative to the build directory.

  
**Problem:** Filters not working in View.
**Solution:** Make sure `cmbFilterRole` and `cmbFilterYear` are wired to call the filter method when changed.

---

> Written with [StackEdit](https://stackedit.io/).
