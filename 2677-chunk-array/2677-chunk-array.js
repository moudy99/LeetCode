/**
 * @param {Array} arr
 * @param {number} size
 * @return {Array}
 */
var chunk = function(arr, size) {
     const mainArr = [];

     const numberOfChunks = size > 0 ? Math.ceil(arr.length / size) : 0;
     for (let i = 0; i < numberOfChunks; i++) {
          const sub = [];
          mainArr.push(arr.splice(0, size));
   
     }
     return mainArr;
     
};