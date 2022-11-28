function solve() {
  let textToTransform = document.getElementById('text').value;
  let convention = document.getElementById('naming-convention').value;
  let result = document.getElementById('result');
  let transformedText = '';
  if (convention === 'Pascal Case') {
    transformedText = textToTransform
      .toLowerCase()
      .split(' ')
      .map((word) => word[0].toUpperCase() + word.slice(1))
      .join('');
  } else if (convention === 'Camel Case') {
    transformedText = textToTransform
      .toLowerCase()
      .split(' ')
      .map((word, index) =>
        index === 0
          ? word
          : word[0].toUpperCase() + word.slice(1)
      )
      .join('');
  } else {
    transformedText = 'Error!';
  }
  result.textContent = transformedText;
}