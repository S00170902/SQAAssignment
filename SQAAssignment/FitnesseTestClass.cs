using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using fit;
using fit.Fixtures;

namespace SQAAssignment
{
    public class FitnesseTestClass: ColumnFixture
    {
        public string gender;
        public int age;

        public PremiumSheet ps = new PremiumSheet();

        public float premium()
        {
            return ps.premium();
        }
    }

    public class PremiumSheet
    {
        private string gender;
        private int age;

        public void setproperties(string g, int a)
        {
            gender = g;
            age = a;
        }

        public float premium()
        {
            InsuranceService insuranceService = new InsuranceService();
            return insuranceService.CalcPremium(age, gender);
        }
    }
}