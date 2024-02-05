using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.Config
{
    public static class Config
    {
        private const string PATHCONFIG = @"../../../../DAL/Repo/Config/Config.txt";

        private static string Gender { get; set; }
        private static string Language { get; set; }
        private static string Repository { get; set; }

        public static string getGender()
        {
            LoadGender();
            return Gender;
        }

        private static void LoadGender()
        {
            string[] lines = File.ReadAllLines(PATHCONFIG);
            string[] parts = lines[0].Split('=');
            Gender = parts[1];
        }

        public static string getLanguage()
        {
            LoadLanguage();
            return Language;
        }

        private static void LoadLanguage()
        {
            string[] lines = File.ReadAllLines(PATHCONFIG);
            string[] parts = lines[1].Split('=');
            Language = parts[1];
        }

        public static string getRepository()
        {
            LoadRepository();
            return Repository;
        }

        private static void LoadRepository()
        {
            string[] lines = File.ReadAllLines(PATHCONFIG);
            string[] parts = lines[2].Split('=');
            Repository = parts[1];
        }
    }
}
