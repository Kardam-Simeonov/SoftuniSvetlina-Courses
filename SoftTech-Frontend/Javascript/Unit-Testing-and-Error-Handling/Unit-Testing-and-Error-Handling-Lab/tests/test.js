const assert = require('chai').assert;
const app = require('../app');

describe("Sum function", function () {
    it('should return NaN if one element of array is not a number', () => {
        assert.equal(isNaN(testSuite.sum([1, 'a'])), true);
    });
    it("should return the sum of the array", function () {
        assert.equal(app.sum([1, 2, 3]), 6);
    });
    it("should not return an incorrect sum", function () {
        assert.notEqual(app.sum([1, 2, 3]), 5);
    });
});