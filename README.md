# iSchool Alumni Birthday Greeting Game

**Team Jeska**  
Kelly Chang, Elaine Lu, Stephanie Ren, Adya Sengupta, Jennie Zheng

## Overview

An interactive and engaging birthday greeting game designed for University of Washington iSchool alumni. This project aims to increase alumni engagement with the iSchool community by transforming traditional birthday messages into an immersive gaming experience.

## Problem Statement

Currently, the iSchool alumni outreach team experiences approximately 10% engagement rates for birthday messages sent to alumni (measured by click-through rates). This low engagement is part of a broader trend in higher education. However, strong alumni-university relations are critical for:
- Providing mentorship opportunities for current students
- Facilitating networking with working professionals
- Forming industry partnerships
- Enabling internships, co-op opportunities, and strategic collaborations

### Why This Matters
By creating a compelling and interactive experience, we aim to strengthen alumni-university connections and foster greater community participation with the iSchool.

### Success Metrics
- **Primary Goal:** Increase alumni birthday greeting interaction rates by 5%
- **Minimum Success Threshold:** 2% increase in interaction rates
- **Delivery Timeline:** Fully working, interactive game by end of Spring Quarter 2026

## Project Goals

## Target Audience

**Primary Audience:**  
iSchool alumni across all programs and graduation years who receive birthday messages from the University of Washington iSchool.

**Secondary Audience:**  
iSchool Alumni Engagement team seeking tools to increase alumni connections and engagement.

## Technologies Used

- **Design:** Figma
- **Frontend:** Unity
- **Backend:** Python
- **Development Tools:** GitHub, Visual Studio Code
- **Version Control:** Git

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- Python 3.9+
- Git
- A code editor (Visual Studio Code recommended)

- **Unity Tutorial:** A super useful tutorial to follow for Unity development can be found here at: https://youtube.com/playlist?list=PLqlFiJjSZ2x1mrMpSQgYdRm8PyWRTg6He&si=m0n_cUZl-_zyxky- (Super Mario Bros Complete Tutorial)

---

**Project Timeline:** Fall 2025 - Spring 2026  
**Sponsor:** University of Washington iSchool Alumni Engagement Team  
**Institution:** University of Washington Information School

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/elainel7/Capstone.git
   cd Capstone
   ```

2. Create and activate a virtual environment (recommended):
   ```bash
   python -m venv venv
   source venv/bin/activate   # On Windows: venv\Scripts\activate
   ```

3. Install dependencies:
   ```bash
   pip install -r requirements.txt
   ```

### Running the backend

Start the API server:

```bash
uvicorn main:app --reload
```

- **API:** http://127.0.0.1:8000  
- **Interactive API docs:** http://127.0.0.1:8000/docs  

Scores are stored in `leaderboard.db` (SQLite) in the project root.

---

## Building and Deployment

### Building for Production

Run the API with uvicorn (no separate build step for the current backend). For production, use a process manager (e.g. Gunicorn with uvicorn workers) and configure your reverse proxy and environment variables as needed.

### Deployment

- Ensure environment variables are set in your production environment.
- Do not commit sensitive credentials to the repository.

## Contributing

We welcome contributions from all team members! Follow these guidelines:

### Workflow

1. **Create a new branch** for your feature or bugfix:
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Make your changes** and commit with clear messages:
   ```bash
   git add .
   git commit -m "Add: clear description of what you added/changed"
   ```

3. **Push to GitHub:**
   ```bash
   git push origin feature/your-feature-name
   ```

4. **Create a Pull Request** on GitHub:
   - Provide a clear title and description
   - Link any related issues
   - Request review from at least one team member

5. **Address review feedback** and merge once approved

### Commit Message Guidelines

Use clear, descriptive commit messages:
- `Add:` for new features
- `Fix:` for bug fixes
- `Update:` for changes to existing features
- `Docs:` for documentation changes
- `Style:` for formatting changes

### Code Style

- Follow consistent formatting (use Prettier for JavaScript/React)
- Write clear comments for complex logic
- Keep functions small and focused
- Write meaningful variable and function names

### Testing

- Write tests for new features
- Ensure all tests pass before submitting a PR
- Maintain or improve code coverage


## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
