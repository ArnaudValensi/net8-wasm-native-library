Module["onRuntimeInitialized"] = function () {
  // Call your function
  const answer = Module.cwrap("Answer", "number", []);
  console.log(answer());
};
