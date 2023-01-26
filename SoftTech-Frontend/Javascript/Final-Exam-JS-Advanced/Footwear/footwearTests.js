const footwear = require('./footwear');
let assert = require('assert');

describe("Footwear tests", () => {
    describe("Generate order tests", () => {
        it("it should throw an error", function() {
            assert.throws(() => footwear.generateOrder({ orderedLaces: 'Nike Laces' }), Error, 'You must order at least one pair of shoes.');
        });
        it("it should return order message without laces", function() {
            assert.equal(footwear.generateOrder({orderedShoes: 'Nike Shoes'}), "Your order contains Nike Shoes");
        });
        it("it should return order message with laces", function() {
            assert.equal(footwear.generateOrder({orderedShoes: 'Nike Shoes', orderedLaces: 'Nike Laces'}), "Your order contains Nike Shoes and Nike Laces.");
        });
    });
    describe("Order status tests", () => {
        it("it should return undefined", function() {
            assert.equal(footwear.orderStatus(), undefined);
        });
        it("it should return final amount", function() {
            assert.equal(footwear.orderStatus(100, 'Delivery'), 100);
        });
        it("it should return final amount with a 10% discount", function() {
            assert.equal(footwear.orderStatus(100, 'New'), 90);
        });
    });
});