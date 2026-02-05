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

## Project Goals

### Success Metrics
- **Primary Goal:** Increase alumni birthday greeting interaction rates by 5%
- **Minimum Success Threshold:** 2% increase in interaction rates
- **Delivery Timeline:** Fully working, interactive game by end of Spring Quarter 2026

### Why This Matters
By creating a compelling and interactive experience, we aim to strengthen alumni-university connections and foster greater community participation with the iSchool.

## Target Audience

**Primary Audience:**  
iSchool alumni across all programs and graduation years who receive birthday messages from the University of Washington iSchool.

**Secondary Audience:**  
iSchool Alumni Engagement team seeking tools to increase alumni connections and engagement.

## Technologies Used

- **Design:** Figma
- **Frontend:** JavaScript, React
- **Backend:** Python
- **Development Tools:** GitHub, Visual Studio Code
- **Version Control:** Git

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- Node.js v18+ and npm
- Python 3.9+
- Git
- A code editor (Visual Studio Code recommended)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/[your-org]/ischool-birthday-game.git
   cd ischool-birthday-game
   ```

2. Install frontend dependencies:
   ```bash
   cd frontend
   npm install
   ```

3. Install backend dependencies:
   ```bash
   cd ../backend
   pip install -r requirements.txt
   ```

### Configuration

1. Create environment files:
   ```bash
   # Frontend
   cd frontend
   cp .env.example .env
   
   # Backend
   cd ../backend
   cp .env.example .env
   ```

2. Configure environment variables as needed:
   ```
   # Example variables
   REACT_APP_API_URL=http://localhost:5000
   DATABASE_URL=your_database_connection
   ```

## Usage

### Running in Development Mode

1. Start the backend server:
   ```bash
   cd backend
   python app.py
   # Or use: python -m flask run
   ```

2. In a new terminal, start the frontend:
   ```bash
   cd frontend
   npm start
   ```

3. Access the application at `http://localhost:3000`

### Running Tests

```bash
# Frontend tests
cd frontend
npm test

# Backend tests
cd backend
python -m pytest
```

## Building and Deployment

### Building for Production

```bash
# Build frontend
cd frontend
npm run build
```

### Deployment

[Add specific deployment instructions once deployment platform is determined]

**Environment Variables for Production:**
- Ensure all necessary environment variables are configured in your production environment
- Never commit sensitive credentials to the repository

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

## Documentation

### Current Documentation
- This README file
- [Link to design files/Figma]
- [Link to project planning documents]

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

**Project Timeline:** Fall 2025 - Spring 2026  
**Sponsor:** University of Washington iSchool Alumni Engagement Team  
**Institution:** University of Washington Information School
