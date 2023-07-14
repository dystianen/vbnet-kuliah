function calculateSalary(hours: number, hourlyRate: number): void {
  const salary = hours * hourlyRate;
  console.log(`Your salary is Rp ${salary}`);
}

calculateSalary(200, 20000);
calculateSalary(210, 20000);