/**
 * @param {string} val
 * @return {Object}
 */
var expect = function (val) {
    const toBe = (value) => {
      if (val === value) return  true ;
      else throw new Error("Not Equal");
    };
  
    const notToBe = (value) => {
      if (val === value) throw new Error("Equal");
      else return  true ;
    };
  
    return { toBe, notToBe };
  };
  
/**
 * expect(5).toBe(5); // true
 * expect(5).notToBe(5); // throws "Equal"
 */