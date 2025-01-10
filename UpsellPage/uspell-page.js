// API Endpoint
const apiEndpoint = "http://localhost:5064/api/Activity";

// Function to fetch and display activities
async function loadActivities() {
  try {
    // Fetch activities from the API
    const response = await fetch(apiEndpoint);
    if (!response.ok) throw new Error("Failed to fetch activities");
    const activities = await response.json();

    // Render activities dynamically
    renderActivities(activities);
  } catch (error) {
    console.error("Error loading activities:", error);
  }
}

// Function to render activities by category
function renderActivities(activities) {
  const categories = {
    "Top Activities": document.querySelector("#top-activities .activity-cards"),
    "Luxury Activities": document.querySelector(
      "#luxury-activities .activity-cards"
    ),
    "Adventure Activities": document.querySelector(
      "#adventure-activities .activity-cards"
    ),
  };

  // Clear existing content in activity cards
  Object.values(categories).forEach((category) => {
    if (category) category.innerHTML = "";
  });

  // Iterate through activities and add them to their respective categories
  activities.forEach((activity) => {
    const cardHTML = `
      <div class="activity-card">
        <img src="${activity.pictureUrl}" alt="${activity.name}" />
        <div class="activity-details">
          <div class="discount">
            <span>Save ${activity.savings}€</span>
            <span>⏱ ${activity.duration}</span>
          </div>
          <h3>${activity.name}</h3>
          <p>${activity.description}</p>
          <p><strong>Price: ${activity.price}€</strong></p>
          <a href="${activity.activityPageUrl}" class="info-reserve" target="_blank">Info & Reserve</a>
        </div>
      </div>
    `;

    // Append the card to the appropriate category
    if (categories[activity.category]) {
      categories[activity.category].innerHTML += cardHTML;
    }
  });
}

// Load activities when the page loads
document.addEventListener("DOMContentLoaded", loadActivities);
