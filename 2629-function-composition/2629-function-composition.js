/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function(functions) {
    
    return function(x) {
                  return functions.reduceRight(function (a, b) {
              return function (x) {
                  return b(a(x));
              }
          }, x => x)(x);
    }
};

/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */