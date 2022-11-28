function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let rows = Array.from(document.querySelectorAll('tbody tr'));
      let input = document.getElementById('searchField').value.toLowerCase();
      rows.forEach(row => {
         row.classList.remove('select');
         if (row.textContent.toLowerCase().includes(input)) {
            row.classList.add('select');
         }
      });
      document.getElementById('searchField').value = '';
   }
}