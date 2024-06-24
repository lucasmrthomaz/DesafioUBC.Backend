﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioUBC.Backend.Data.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO Student (Nome, Idade, Serie, NotaMedia, Endereco, NomePai, NomeMae, DataNascimento) VALUES
                ('Alice', 10, 5, 8.5, '123 Main St', 'John Doe', 'Jane Doe', '2013-05-15'),
                ('Bob', 11, 6, 7.2, '456 Oak St', 'Bob Smith', 'Alice Smith', '2012-08-21'),
                ('Charlie', 9, 4, 9.0, '789 Pine St', 'Charlie Brown', 'Lucy Brown', '2014-02-10'),
                ('David', 10, 5, 8.8, '101 Cedar St', 'David Johnson', 'Emily Johnson', '2013-07-18'),
                ('Emma', 11, 6, 7.5, '202 Elm St', 'Michael White', 'Sophia White', '2012-10-05'),
                ('Frank', 9, 4, 9.2, '303 Maple St', 'Frank Williams', 'Grace Williams', '2014-01-22'),
                ('Grace', 10, 5, 8.0, '404 Birch St', 'George Taylor', 'Olivia Taylor', '2013-04-30'),
                ('Henry', 11, 6, 7.8, '505 Spruce St', 'Henry Moore', 'Lily Moore', '2012-09-14'),
                ('Isabel', 9, 4, 9.5, '606 Walnut St', 'Isaac Davis', 'Ava Davis', '2014-03-07'),
                ('Jack', 10, 5, 7.9, '707 Sycamore St', 'Jack Smith', 'Emma Smith', '2013-06-19'),
                ('Katherine', 11, 6, 8.3, '808 Cedar St', 'James Martin', 'Sophia Martin', '2012-11-28'),
                ('Liam', 9, 4, 9.1, '909 Oak St', 'Liam Turner', 'Ella Turner', '2014-02-01'),
                ('Mia', 10, 5, 8.7, '1010 Maple St', 'Ryan Brown', 'Mia Brown', '2013-05-12'),
                ('Nathan', 11, 6, 7.4, '1111 Birch St', 'Nathan Harris', 'Eva Harris', '2012-08-03'),
                ('Olivia', 9, 4, 9.3, '1212 Pine St', 'Daniel Green', 'Olivia Green', '2014-01-09'),
                ('Peter', 10, 5, 8.4, '1313 Elm St', 'Peter Clark', 'Ava Clark', '2013-04-18'),
                ('Quinn', 11, 6, 7.1, '1414 Cedar St', 'Quinn Davis', 'Grace Davis', '2012-09-27'),
                ('Rachel', 9, 4, 9.4, '1515 Walnut St', 'Richard White', 'Rachel White', '2014-02-14'),
                ('Sam', 10, 5, 8.6, '1616 Sycamore St', 'Sam Turner', 'Emily Turner', '2013-06-06'),
                ('Tristan', 11, 6, 7.7, '1717 Spruce St', 'Tristan Harris', 'Lily Harris', '2012-11-23'),
                ('Uma', 9, 4, 9.6, '1818 Maple St', 'Uma Smith', 'Sophia Smith', '2014-03-30'),
                ('Victor', 10, 5, 8.2, '1919 Oak St', 'Victor Martin', 'Ella Martin', '2013-05-24'),
                ('Wendy', 11, 6, 7.0, '2020 Pine St', 'Wendy Brown', 'Michael Brown', '2012-10-10'),
                ('Xander', 9, 4, 9.7, '2121 Birch St', 'Xander Turner', 'Sophia Turner', '2014-01-17'),
                ('Yara', 10, 5, 8.1, '2222 Elm St', 'Yara Davis', 'John Davis', '2013-04-04'),
                ('Zane', 11, 6, 7.3, '2323 Cedar St', 'Zane Harris', 'Lily Harris', '2012-09-08'),
                ('Aaron', 9, 4, 9.8, '2424 Walnut St', 'Aaron Smith', 'Sophia Smith', '2014-02-21'),
                ('Bella', 10, 5, 8.9, '2525 Sycamore St', 'Bella Martin', 'Ella Martin', '2013-06-14'),
                ('Carlos', 11, 6, 7.6, '2626 Spruce St', 'Carlos Turner', 'Emily Turner', '2012-11-05'),
                ('Diana', 9, 4, 9.9, '2727 Maple St', 'Diana White', 'Michael White', '2014-03-18'),
                ('Ethan', 10, 5, 8.8, '2828 Oak St', 'Ethan Brown', 'Sophia Brown', '2013-04-23'),
                ('Fiona', 11, 6, 7.5, '2929 Pine St', 'Fiona Harris', 'John Harris', '2012-10-16'),
                ('Gavin', 9, 4, 9.2, '3030 Birch St', 'Gavin Smith', 'Olivia Smith', '2014-01-03'),
                ('Holly', 10, 5, 8.0, '3131 Cedar St', 'Holly Davis', 'Daniel Davis', '2013-05-29'),
                ('Ian', 11, 6, 7.8, '3232 Elm St', 'Ian Turner', 'Sophia Turner', '2012-09-20'),
                ('Jenna', 9, 4, 9.5, '3333 Sycamore St', 'Jenna Martin', 'Ella Martin', '2014-02-26'),
                ('Kevin', 10, 5, 8.4, '3434 Spruce St', 'Kevin Harris', 'Lily Harris', '2013-06-09'),
                ('Lila', 11, 6, 7.2, '3535 Maple St', 'Lila White', 'Michael White', '2012-08-14'),
                ('Mark', 9, 4, 9.3, '3636 Oak St', 'Mark Brown', 'Sophia Brown', '2014-01-12'),
                ('Nina', 10, 5, 8.7, '3737 Pine St', 'Nina Smith', 'Olivia Smith', '2013-05-17'),
                ('Oscar', 11, 6, 7.9, '3838 Birch St', 'Oscar Turner', 'Emily Turner', '2012-09-30'),
                ('Paula', 9, 4, 9.4, '3939 Elm St', 'Paula Harris', 'John Harris', '2014-03-11'),
                ('Quincy', 10, 5, 8.1, '4040 Cedar St', 'Quincy Davis', 'Daniel Davis', '2013-04-01'),
                ('Ruby', 11, 6, 7.7, '4141 Sycamore St', 'Ruby Martin', 'Ella Martin', '2012-11-30'),
                ('Steve', 9, 4, 9.6, '4242 Spruce St', 'Steve White', 'Michael White', '2014-02-04'),
                ('Tina', 10, 5, 8.3, '4343 Maple St', 'Tina Brown', 'Sophia Brown', '2013-05-08'),
                ('Ursula', 11, 6, 7.1, '4444 Oak St', 'Ursula Smith', 'Olivia Smith', '2012-08-27'),
                ('Vince', 9, 4, 9.1, '4545 Pine St', 'Vince Turner', 'Emily Turner', '2014-01-20'),
                ('Wes', 10, 5, 8.9, '4646 Birch St', 'Wes Harris', 'Lily Harris', '2013-04-27'),
                ('Xena', 11, 6, 7.4, '4747 Elm St', 'Xena Davis', 'John Davis', '2012-09-13'),
                ('Yvonne', 9, 4, 9.7, '4848 Sycamore St', 'Yvonne Martin', 'Ella Martin', '2014-03-24'),
                ('Zach', 10, 5, 8.2, '4949 Spruce St', 'Zach White', 'Michael White', '2013-05-03');
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Alunos");
        }
    }
}