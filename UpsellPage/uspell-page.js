// Function to scroll left

function scrollLeft() {
  const container = document.querySelector(".buttons-container");

  container.scrollBy({
    left: -200, // Adjust scroll distance as needed

    behavior: "smooth",
  });
}

// Function to scroll right

function scrollRight() {
  const container = document.querySelector(".buttons-container");

  container.scrollBy({
    left: 200, // Adjust scroll distance as needed

    behavior: "smooth",
  });
}
