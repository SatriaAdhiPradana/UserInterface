using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HW3
{
    public class Service1 : IService1
    {
        public string population(string input)
        {
            string population = "";
            input = input.ToLower();
            if (input.Equals("africa", StringComparison.OrdinalIgnoreCase))
            {
                population = "1,110,635,000";
            }
            else if (String.Equals(input, "asia", StringComparison.OrdinalIgnoreCase))
            {
                population = "4,298,723,000";
            }
            else if (input.Equals("europe", StringComparison.OrdinalIgnoreCase))
            {
                population = "742,452,000";
            }
            else if (input.Equals("north america", StringComparison.OrdinalIgnoreCase))
            {
                population = "565,265,000";
            }
            else if (input.Equals("south america", StringComparison.OrdinalIgnoreCase))
            {
                population = "406,740,000";
            }
            else if ((input.Equals("australia", StringComparison.OrdinalIgnoreCase)) || (input.Equals("oceania", StringComparison.OrdinalIgnoreCase)))
            {
                population = "38,304,000";
            }
            else if (input.Equals("antartica", StringComparison.OrdinalIgnoreCase))
            {
                population = "4,490";
            }
            else
            {
                population = "Invalid Input";
            }
            return population;
        }
        public string password(int passwordLength)
        {
            const string possibleCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*(){}[]|?.,";
            StringBuilder password = new StringBuilder();
            Random rnd = new Random();
            while (0 < passwordLength--)
            {
                password.Append(possibleCharacters[rnd.Next(possibleCharacters.Length)]);
            }
            return password.ToString();

        }
        public string expenses(double totalbudget, double duration, int members)
        {
            double initial = totalbudget;
            double dailyBudget = totalbudget / duration;
            String output = dailyBudget.ToString();
            string info = "Cost Averages by ValuePenguin,   ";
            double flights = 1000;
            flights = flights * 2;
            flights = flights * members;
            totalbudget = totalbudget - flights;
            double lodging = 150;
            lodging = lodging * duration;
            totalbudget = totalbudget - lodging;
            double food = 20 + 30 + 50;
            food = food * members;
            food = food * duration;
            totalbudget = totalbudget - food;
            bool afford=false;
            double expenses = food + flights + lodging;
            if (totalbudget > 0)
            {
                afford = true;
            }
            dailyBudget = totalbudget / duration;
            if (!afford)
            {
                output = info + "These numbers indicate you do not have sufficent funds to travel with";
                output = output + "Total expenses: $" + expenses.ToString() + ", Leftover Budget: $" + totalbudget.ToString() + ", Daily Budget Allowance: $" + dailyBudget.ToString() + ", Flight Costs: $" + flights.ToString() + ", Lodging Costs: $" + lodging.ToString() + ", Food Costs: $" + food.ToString() + ", These are your expense estimates"; 

            }
            if (dailyBudget < 0)
            {
                output = info+"Your budget is inadequate given average travel and lodging prices. ";
                output = output + "Total expenses: $" + expenses.ToString() + ", Leftover Budget: $" + totalbudget.ToString() + ", Daily Budget Allowance: $" + dailyBudget.ToString() + ", Flight Costs: $" + flights.ToString() + ", Lodging Costs: $" + lodging.ToString() + ", Food Costs: $" + food.ToString() + ", These are your expense estimates"; 
            }
            if(afford)
            {
                output = info + "Total expenses: $" + expenses.ToString() + ", Leftover Budget: $" + totalbudget.ToString() + ", Daily Budget Allowance: $" + dailyBudget.ToString() + ", Flight Costs: $" + flights.ToString() + ", Lodging Costs: $" + lodging.ToString() + ", Food Costs: $" + food.ToString()+", These are your expense estimates"; 
            }

            return output;
        }
        public string list(string inputList)
        {
            int inputLength = inputList.Length;
            bool comma = false;
            bool space = false;
            for (int x = 0; x < inputLength; x++)
            {
                char myChar = inputList[x];
                if (myChar.Equals(','))
                {
                    comma = true;
                }
                else if(myChar.Equals(' '))
                {
                    space = true;
                }
            }
            if (comma)
            {
                string[] wordss = inputList.Split(',');
            }
            else if (space)
            {
                string[] wordss = inputList.Split(' ');
            }
            string completeList = "";
            string[] words = inputList.Split(' ');
            int length = words.Length;
            for (int x = 0; x < length; x++)
            {
                words[x] = words[x].ToLower();
            }
            int i, j;
            for (i = 1; i < words.Length; i++)
            {
                string value = words[i];
                j = i - 1;
                while ((j >= 0) && (words[j].CompareTo(value) > 0))
                {
                    words[j + 1] = words[j];
                    j--;
                }
                words[j + 1] = value;
            }
            for (i = 0; i < length; i++)
            {
                string word = words[i];
                word = char.ToUpper(word[0]) + word.Substring(1);
                words[i]= word;
            }
            for (i = 0; i < length; i++)
            {
                int count = i + 1;
                string word = words[i];
                word = count.ToString() + ". " + word;
                words[i] = word;
            }
            completeList = length.ToString() + " places:   ";
            foreach (var item in words)
            {
                completeList = completeList + item + "   ";
            }
            return completeList;
        }
    }
}
