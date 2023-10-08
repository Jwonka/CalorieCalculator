//Author: Josh Werlein
//Purpose: Make an application that calculates calories
//Date: 09/24/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalorieCalculator
{
    internal class User
    {
        //Define Class level Variables
        private int mUserID;
        private string mName;
        private decimal mAge;
        private decimal mHeight;
        private decimal mWeight;
        private string mGender;
        private string mActivityLevel;
        private decimal mActivityLevelRate;
        private decimal mWaist;
        private decimal mHip;
        private decimal mForearm;
        private decimal mWrist;
        private decimal mLeanBodyMass;
        private decimal mBaseMetabolicRate;
        private decimal mBodyFatWeight;
        private decimal mBodyFatPercentage;

        public int UserID { get { return mUserID; } set { mUserID = value; } }
        public string Name { get { return mName; } set { mName = value; } }
        public decimal Age { get {  return mAge; } set { mAge = value;  } }
        public decimal Height { get { return mHeight; } set { mHeight = value; } }
        public decimal Weight { get {  return mWeight; } set { mWeight = value; } }
        public string Gender { get {  return mGender; } set { mGender = value; } }
        public string ActivityLevel { get {  return mActivityLevel; } set { mActivityLevel = value; } }
        public decimal ActivityMetabolicRate { get { return mActivityLevelRate; } set { mActivityLevelRate = value; } }
        public decimal Waist { get { return mWaist; } set { mWaist = value; } }
        public decimal Hip { get { return mHip; } set { mHip = value; } }
        public decimal Forearm { get { return mForearm; } set { mForearm = value; } }
        public decimal Wrist { get {  return mWrist; } set { mWrist = value; } }
        public decimal BaseMetabolicRate { get {  return mBaseMetabolicRate; } set { mBaseMetabolicRate = value; } }
        public decimal BodyFatPercentage { get { return mBodyFatPercentage; } set { mBodyFatPercentage = value; } }
        public decimal BodyFatWeight { get { return mBodyFatWeight; } set { mBodyFatWeight = value; } }
        public decimal LeanBodyMass { get { return mLeanBodyMass; } set { mLeanBodyMass = value; } }


        //Default constructor
        public User()
        {
            this.mUserID = 0;
            this.mName = string.Empty;
            this.mAge = 0;
            this.mHeight = 0;
            this.mWeight = 0;
            this.mGender = string.Empty;
            this.mActivityLevel = string.Empty;
            this.mActivityLevelRate = 0;
            this.mWaist = 0;
            this.mHip = 0;
            this.mForearm = 0;
            this.mWrist = 0;
            this.mLeanBodyMass = 0;
            this.mBaseMetabolicRate = 0;
            this.mBodyFatPercentage = 0;
            this.mBodyFatWeight = 0;
        }

        //Overloaded Constructor
        public User(string name)
        {
            this.mName = name;
            this.mUserID = 0;
            this.mAge = 0;
            this.mHeight = 0;
            this.mWeight = 0;
            this.mGender = string.Empty;
            this.mActivityLevel = string.Empty;
            this.mActivityLevelRate = 0;
            this.mWaist = 0;
            this.mHip = 0;
            this.mForearm = 0;
            this.mWrist = 0;
            this.mLeanBodyMass = 0;
            this.mBaseMetabolicRate = 0;
            this.mBodyFatPercentage = 0;
            this.mBodyFatWeight = 0;
        }

        //Overloaded constructor for UserID
        public User(int UserID)
        {
            mUserID = UserID;
            this.mName = string.Empty;
            this.mAge = 0;
            this.mHeight = 0;
            this.mWeight = 0;
            this.mGender = string.Empty;
            this.mActivityLevel = string.Empty;
            this.mActivityLevelRate = 0;
            this.mWaist = 0;
            this.mHip = 0;
            this.mForearm = 0;
            this.mWrist = 0;
            this.mLeanBodyMass = 0;
            this.mBaseMetabolicRate = 0;
            this.mBodyFatPercentage = 0;
            this.mBodyFatWeight = 0;
        }

        //Method for string description of the selected user
        public string User_Description()
        {
            return Name + " is " + Age + " Year old " + Gender + " " + Height + " in. tall weighing " + Weight + " lbs." + " has a " + BodyFatPercentage + "%" + " body fat" + " a Base Metabolic Rate of " + BaseMetabolicRate + " calories " + "a Active Metabolic Rate of " + ActivityMetabolicRate + " calories based on " + ActivityLevel + " activity level";
        }
    }
}
