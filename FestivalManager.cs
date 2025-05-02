using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025ArtofBeautyFestival
{
    internal class FestivalManager
    {

            private static string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles", "participants.xml");

            public static DataTable LoadParticipants()
            {
                if (!File.Exists(xmlFilePath))
                    throw new FileNotFoundException("Participant data not found.");

                DataTable table = new DataTable();
                table.ReadXml(xmlFilePath);
                return table;
            }

            public static void DisplayAllParticipants()
            {
                DataTable participants = LoadParticipants();

                foreach (DataRow row in participants.Rows)
                {
                    string name = $"{row["FirstName"]} {row["LastName"]}";
                    string role = row["Role"].ToString();

                    Console.WriteLine($"- {name} | Role: {role}");

                    if (role == "Performer" && row.Table.Columns.Contains("PerformanceType"))
                        Console.WriteLine($"    • Type: {row["PerformanceType"]}");
                    if (role == "Vendor" && row.Table.Columns.Contains("ProductType"))
                        Console.WriteLine($"    • Product: {row["ProductType"]}");
                    if (role == "Beauty Artist" && row.Table.Columns.Contains("ServiceType"))
                        Console.WriteLine($"    • Service: {row["ServiceType"]}");
                }
            }

            public static decimal CalculateTotalFees()
            {
                DataTable participants = LoadParticipants();
                return participants.AsEnumerable()
                    .Sum(row => decimal.TryParse(row["Fee"].ToString(), out var fee) ? fee : 0);
            }

            public static DataRow ParticipantSearch(string searchTerm)
            {
                DataTable participants = LoadParticipants();
                return participants.AsEnumerable().FirstOrDefault(row =>
                    row["FirstName"].ToString().Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    row["LastName"].ToString().Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    $"{row["FirstName"]} {row["LastName"]}".Equals(searchTerm, StringComparison.OrdinalIgnoreCase)
                );
            }
     }
}
