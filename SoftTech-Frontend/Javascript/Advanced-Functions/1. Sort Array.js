function sortArray(arr, sortParam) {
    if (sortParam == 'asc') {
        return arr.sort((a, b) => a - b);
    } else if (sortParam == 'desc') {
        return arr.sort((a, b) => b - a);
    }
}

