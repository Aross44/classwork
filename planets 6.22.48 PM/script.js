const planets = [
    { name: "Mercury", inner: true, diameter: 3031.9, color: "#696969" },
    { name: "Venus", inner: true, diameter: 7520.8, color: "#b89165" },
    { name: "Earth", inner: true, diameter: 7917.5, color: "#5a5b86" },
    { name: "Mars", inner: true, diameter: 4212.3, color: "#df8c4e" },
    { name: "Jupiter", inner: false, diameter: 86881, color: "#f6a049" },
    { name: "Saturn", inner: false, diameter: 72367, color: "#dcd3a1" },
    { name: "Uranus", inner: false, diameter: 31518, color: "#b4d9df" },
    { name: "Neptune", inner: false, diameter: 30599, color: "#456eff" }
  ];
  
  let index = 0;
  
  const prevBtn = document.getElementById("prevBtn");
  const nextBtn = document.getElementById("nextBtn");
  
  const indexEl = document.getElementById("index");
  const nameEl = document.getElementById("planetName");
  const typeEl = document.getElementById("planetType");
  const visualEl = document.getElementById("planetVisual");
  
  function updatePlanetDisplay() {
    const planet = planets[index];
    indexEl.innerText = index;
    nameEl.innerText = planet.name;
    typeEl.innerText = planet.inner ? "Inner Planet" : "Outer Planet";
    visualEl.style.backgroundColor = planet.color;
    const size = planet.diameter / 100;
    visualEl.style.width = size + "px";
    visualEl.style.height = size + "px";
  
    prevBtn.disabled = index === 0;
    nextBtn.disabled = index === planets.length - 1;
  }
  
  prevBtn.addEventListener("click", () => {
    if (index > 0) {
      index--;
      updatePlanetDisplay();
    }
  });
  
  nextBtn.addEventListener("click", () => {
    if (index < planets.length - 1) {
      index++;
      updatePlanetDisplay();
    }
  });
  
  updatePlanetDisplay();
