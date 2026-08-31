# Relic Run — Enterprise Endless Runner & Game Platform

Relic Run is an original, high-fidelity third-person endless running adventure game and distributed backend service platform.

---

## 🌟 Architecture Overview

```
RelicRun/
├── UnityClient/            # Unity C# Client Architecture
│   └── Assets/Scripts/     # Core, Player, World, Obstacles, PowerUps, AI Chaser, UI, Networking
├── Backend/                # Python FastAPI Distributed Backend Services
│   ├── app/                # API Endpoints, Models, Repositories, Analytics, NVIDIA Gateway
│   └── tests/              # Pytest automated test matrix
├── Infrastructure/         # Docker Compose, PostgreSQL configurations
├── docs/                   # Architecture, Game Design, API & Deployment Specifications
├── scripts/                # Standalone demo runner & diagnostic probes
└── index.html              # Standalone 3D WebGL Playable Edition
```

---

## 🚀 Quick Start

### 1. Run the Standalone Game Probe
```bash
python scripts/demo_run.py
```

### 2. Play the 3D Web Game
Open `index.html` directly in your browser or serve with:
```bash
python -m http.server 8000
```

### 3. Run Backend Test Matrix
```bash
pytest Backend/tests/ -v
```
