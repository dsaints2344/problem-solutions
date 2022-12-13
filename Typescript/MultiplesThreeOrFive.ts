function getMultipleSum(limit: number) {
    const numbersToMultiply = [3, 5];
    let savedMultiples: number[] = [];
    let currentMultiple = 1;

    numbersToMultiply.forEach((n) => {
        let counter = 1;
        while (n * counter < limit) {
            currentMultiple = n * counter;
            savedMultiples.push(currentMultiple);
            counter++;
        }
        currentMultiple = 0;
    })

    const savedUniqueMultiples = [...new Set(savedMultiples.sort((a, b) => a - b))];
    return savedUniqueMultiples.reduce((pv, cv) => {
        return pv + cv;
    })

}

console.log(getMultipleSum(10));