===================== Description of the project ======================
* This is a webAPI project developed using .Net Core 3.0 entity framework and MS SQL
* It includes all the CRUD actions related to a blood donation campaign
================= Reqiurements to execte the project ==================
1. Install visual Studio
2. Install MS SQL srver management studio with SQL server

====================== How to execte the project ======================
1. Clone the project
2. Create a database in SQL EXPRESS named "DonationDB"
3. Build the project "Webapi"
4. Go to package manager console and execute "Add-Migration <put-your-migration-identity-name>"
   i.e. Add-Migration InitialMigration
   
5. Run "Update-Database" in package manager console
6. Run the project "Webapi"
7. Check the functionality using Postman by accessing "DonationCandidateController"
   i.e. GET: api/DonationCandidate
        GET: api/DonationCandidate/1
		POST:api/DonationCandidate
		DELETE: api/DonationCandidate/1
   