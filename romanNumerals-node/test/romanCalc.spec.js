const assert = require('chai').assert;
const { convertToRoman } = require('../lib/romanCalc');

describe('Given 1', () => {
  it('Should return correct result (I)', () => {
    const result = convertToRoman(1);
    assert.equal(result, 'I');
  });
});
describe('Given 2', () => {
  it('Should return correct result (II)', () => {
    const result = convertToRoman(2);
    assert.equal(result, 'II');
  });
});
describe('Given 4', () => {
  it('Should return correct result (IV)', () => {
    const result = convertToRoman(4);
    assert.equal(result, 'IV');
  });
});
describe('Given 5', () => {
  it('Should return correct result (V)', () => {
    const result = convertToRoman(5);
    assert.equal(result, 'V');
  });
});
describe('Given 8', () => {
  it('Should return correct result (VIII)', () => {
    const result = convertToRoman(8);
    assert.equal(result, 'VIII');
  });
});
describe('Given 19', () => {
  it('Should return correct result (XIX)', () => {
    const result = convertToRoman(19);
    assert.equal(result, 'XIX');
  });
});
describe('Given 22', () => {
  it('Should return correct result (XXII)', () => {
    const result = convertToRoman(22);
    assert.equal(result, 'XXII');
  });
});
describe('Given 89', () => {
  it('Should return correct result (LXXXIX)', () => {
    const result = convertToRoman(89);
    assert.equal(result, 'LXXXIX');
  });
});
describe('Given 99', () => {
  it('Should return correct result (XCIX)', () => {
    const result = convertToRoman(99);
    assert.equal(result, 'XCIX');
  });
});