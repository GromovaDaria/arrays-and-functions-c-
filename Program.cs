/* int GetRandomThreeDigitNumberGetSecond() {
            var rd = new Random();
            var number = rd.Next(100, 999);
            Console.WriteLine($"Random number: {number}");

            return Convert.ToInt32(number.ToString().Substring(1, 1));
        }
Console.WriteLine(GetRandomThreeDigitNumberGetSecond()); */


/*void GetRandomDisplayThirdDigit() {
            var rd = new Random();
            var number = rd.Next();  //or var number = rd.Next(50, 10000);
            Console.WriteLine($"Random number: {number}");

            if (number < 100) Console.WriteLine($"Number {number} does not contain three digits");
            
            else {
                var thirdDigit = number.ToString().Substring(2, 1);
                Console.WriteLine($"Third digit of {number} is {thirdDigit}");
            }
        }
        GetRandomDisplayThirdDigit(); */


void IsItHoliday() {
            Console.Write("Write weekday number (1-7): ");
            var weekday = Console.ReadLine();

            if (Int32.TryParse(weekday, out var parsedNumber)) {
                switch(parsedNumber) {
                    case 1:
                    case 2:
                    case 3: 
                    case 4:
                    case 5:
                    Console.WriteLine("This is not a holiday");
                    break;

                    case 6:
                    case 7:
                    Console.WriteLine("This is a holiday");
                    break;

                    default:
                    Console.WriteLine("Number is not a valid day");
                    break;
                }
            }

            else Console.WriteLine("Input is not a number");
        }
        IsItHoliday();