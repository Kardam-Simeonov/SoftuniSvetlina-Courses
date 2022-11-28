function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      let input = JSON.parse(document.querySelector('#inputs textarea').value);
      let restaurants = {};

      input.forEach(line => {
         let [name, workers] = line.split(' - ');
         workers = workers.split(', ').map(w => {
            let [name, salary] = w.split(' ');
            return {name, salary: Number(salary)};
         });

         if (restaurants[name]) {
            workers = workers.concat(restaurants[name].workers);
         }

         let bestSalary = workers.reduce((a, b) => a.salary > b.salary ? a : b).salary;

         restaurants[name] = {
            workers,
            bestSalary
         };
      });

      let bestRestaurantSalary = 0;
      let bestRestaurantName = '';
      let bestRestaurantWorkers = [];

      for (const restaurantName in restaurants) {
         let totalSalary = restaurants[restaurantName].workers.reduce((a, b) => a + b.salary, 0);
         if (totalSalary > bestRestaurantSalary) {
            bestRestaurantSalary = totalSalary;
            bestRestaurantName = restaurantName;
            bestRestaurantWorkers = restaurants[restaurantName].workers;
         }
      }

      let bestRestaurant = `Name: ${bestRestaurantName} Average Salary: ${bestRestaurantSalary / bestRestaurantWorkers.length.toFixed(2)} Best Salary: ${restaurants[bestRestaurantName].bestSalary.toFixed(2)}`;
      let workersResult = 'Workers:';

      bestRestaurantWorkers
         .sort((a, b) => b.salary - a.salary)
         .forEach(w => workersResult += ` ${w.name} ${w.salary}`);

      document.querySelector('#bestRestaurant p').textContent = bestRestaurant;
      document.querySelector('#workers p').textContent = workersResult;
      
   }
}