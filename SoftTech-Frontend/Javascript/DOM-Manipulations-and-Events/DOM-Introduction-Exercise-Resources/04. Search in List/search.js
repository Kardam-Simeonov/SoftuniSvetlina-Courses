function search() {
   let input = document.querySelector('#searchText');
   let towns = document.querySelectorAll('ul li');
   let result = document.querySelector('#result');
   let count = 0;

   for (let town of towns) {
      if (town.textContent.includes(input.value)) {
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
         count++;
      }
      else {
         town.style.fontWeight = '';
         town.style.textDecoration = '';
      }
   }

   result.textContent = `${count} matches found`;
}
