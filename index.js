var isValid = function (s) {
  const stack = [];
  const bracketPairs = {
    "(": ")",
    "[": "]",
    "{": "}",
  };

  for (let char of s) {
    if (bracketPairs[char]) {
      // If it's an opening bracket, push it onto the stack.
      stack.push(char);
    } else {
      // If it's a closing bracket, check if it matches the top of the stack.
      if (stack.length === 0 || bracketPairs[stack.pop()] !== char) {
        return false; // Invalid, the brackets don't match.
      }
    }
  }

  return stack.length === 0; // If the stack is empty, it's valid.
};

//examples
console.log(isValid("()"));
console.log(isValid("()[]{}"));
console.log(isValid("(]"));
