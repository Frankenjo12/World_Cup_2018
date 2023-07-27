using DAL.Model;
using DAL.Repo.APIRepo;
using DAL.Repo.FileRepo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace DAL.Repo
{
    public static class RepoFactory
    {
        private const string PATH = @"../../../../DAL/Repo/Config/Config.txt";
        private const char DEL = '=';
        public static IRepo GetRepo()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
            string[] lines = File.ReadAllLines(PATH);
            
            foreach(string line in lines)
            {
                string[] parts = line.Split(DEL);
                if (parts[0] == "REPOSITORY")
                {
                    if (parts[1] == "API")
                    {
                        return new APIRepo.APIRepo();
                    }
                }
            }

            return new FileRepo.FileRepo();
        }
    }
}