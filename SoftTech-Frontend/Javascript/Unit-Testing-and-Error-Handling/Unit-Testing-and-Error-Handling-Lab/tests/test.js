const assert = require('chai').assert;
const app = require('../app');

describe("Sum function", function () {
    it('should return NaN if one element of array is not a number', () => {
        assert.equal(isNaN(app.sum([1, 'a'])), true);
    });
    it("should return the sum of the array", function () {
        assert.equal(app.sum([1, 2, 3]), 6);
    });
    it("should not return an incorrect sum", function () {
        assert.notEqual(app.sum([1, 2, 3]), 5);
    });
});

describe("isSymmetric function", function () {
    it('should return true if is symmetric', ()=>{
        assert.isTrue(isSymmetric([1,0,0,1]));
    });
    it('should return false if is not symmetric', ()=>{
        assert.isFalse(isSymmetric([1,0,0,1,1]));
    });
    it('should return false if is not an array', ()=>{
        assert.isFalse(isSymmetric('string'));
    });
    it('should return true with multitype symmetric array', ()=>{
        assert.isTrue(isSymmetric([1,2,'1',3.1]));
    });
    it('should return false with multitype insymmetric array', ()=>{
        assert.isFalse(isSymmetric([1,2,'1']));
    });
});

describe("rgbToHex function", function() {
    it('should return undefined for missing or invalid params', ()=>{
        assert.equal(rgbToHexColor(0),undefined);
        assert.equal(rgbToHexColor(0, 0, '0'),undefined);
    });
 
    it('should return undefined for out of lower bounds params', ()=>{
        assert.equal(rgbToHexColor(-1,-1,0),undefined);
    });
 
    it('should return undefined for out of upper bounds params', ()=>{
        assert.equal(rgbToHexColor(256,389,0),undefined);
    });
    it('should convert 0,0,0 to black', ()=>{
        assert.equal(rgbToHexColor(0,0,0),'#000000');
    });
    it('should convert 255,255,255 to white', ()=>{
        assert.equal(rgbToHexColor(255,255,255),'#FFFFFF');
    });
});