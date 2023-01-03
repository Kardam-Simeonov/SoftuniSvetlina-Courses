const assert = require('chai').assert;
const app = require('../app');

describe("isOddOrEven function", function () {
    it('should return undefined if parameter is not string', () => {
        assert.equal(isOddOrEven(123), undefined);
    });
    it('should return even if string is even', () => {
        assert.equal(isOddOrEven('even'), 'even');
    });
    it('should return odd if string is odd', () => {
        assert.equal(isOddOrEven('odd'), 'odd');
    });
    it('should return correct results on different strings', () => {
        assert.equal(isOddOrEven('apple'), 'odd');
        assert.equal(isOddOrEven('bear'), 'even');
        assert.equal(isOddOrEven('crayon'), 'even');
    });
});