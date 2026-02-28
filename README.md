# Git 101 Workshop - Code Network 2026

Welcome to the Git 101 Workshop! This project is designed to teach Code Network members the fundamentals of using Git and GitHub for collaborative software development.

## Table of Contents

- [Workshop Goal](#workshop-goal)
- [Project Description](#project-description)
- [Prerequisites](#prerequisites)
- [Choosing Your Git Tool](#choosing-your-git-tool)
  - [Option 1: Git CLI](#option-1-git-cli-command-line-interface---recommended-for-learning)
  - [Option 2: GitHub CLI](#option-2-github-cli---advanced-command-line-tool)
  - [Option 3: GitHub Desktop](#option-3-github-desktop---visual-interface)
- [Workshop Steps](#workshop-steps)
  - [Step 1: Fork the Repository](#step-1-fork-the-repository)
  - [Step 2: Clone Your Fork](#step-2-clone-your-fork)
  - [Step 3: Make Your Changes](#step-3-make-your-changes)
  - [Step 4: Test Your Changes](#step-4-test-your-changes-optional)
  - [Step 5: Stage Your Changes](#step-5-stage-your-changes)
  - [Step 6: Commit Your Changes](#step-6-commit-your-changes)
  - [Step 7: Push to Your Fork](#step-7-push-to-your-fork)
  - [Step 8: Create a Pull Request](#step-8-create-a-pull-request)
- [Alternative Workflows](#alternative-workflows)
  - [Using GitHub CLI](#using-github-cli)
  - [Using GitHub Desktop](#using-github-desktop)
- [Useful Commands Reference](#useful-commands-reference)
  - [Git CLI Commands](#git-cli-commands)
  - [GitHub CLI Commands](#github-cli-commands)
  - [GitHub Desktop](#github-desktop)
- [Troubleshooting](#troubleshooting)
  - [Merge Conflicts](#merge-conflicts)
  - [Need to Update Your Fork?](#need-to-update-your-fork)
- [Contributing Guidelines](#contributing-guidelines)
- [Questions?](#questions)
- [Additional Resources](#additional-resources)

## Workshop Goal

By the end of this workshop, you will learn how to:
- Fork a repository on GitHub
- Clone a repository to your local machine
- Make changes to code
- Stage and commit your changes
- Push changes to your remote repository
- Create a pull request to contribute to the original project

## Project Description

This is a simple C# console application that displays a welcome message and lists all the awesome coders who attended this workshop. Your task is to add your name to the attendees list!

## Prerequisites

Before starting, make sure you have:
- [Git](https://git-scm.com/install) installed on your computer
- A [GitHub](https://github.com) account
- _(Optional)_[.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed (to run the program)
- A code editor (e.g., NotePad++, Visual Studio, VS Code, or Rider)

## Choosing Your Git Tool

You have three main options for working with Git and GitHub. Choose the one that best fits your comfort level:

**Quick Decision Guide:**
- **New to Git?** → Start with GitHub Desktop (easiest to visualize)
- **Want to learn Git deeply?** → Use Git CLI (useful for advanced features)
- **Want GitHub-specific features?** → Try GitHub CLI (powerful shortcuts)
- **Can't decide?** → Git CLI is the most versatile and widely used

### Option 1: Git CLI (Command Line Interface) - Recommended for Learning

The traditional Git command-line tool. Best for understanding Git fundamentals.

**Setup:**
1. Download and install from [git-scm.com/install](https://git-scm.com/install)
2. Open terminal/command prompt and verify installation:
   ```bash
   git --version
   ```
3. Configure your identity:
   ```bash
   git config --global user.name "Your Name"
   git config --global user.email "your.email@example.com"
   ```

**Best for:** Learning Git fundamentals, available everywhere, most documentation uses this

### Option 2: GitHub CLI - Advanced Command Line Tool

GitHub's official CLI tool with enhanced GitHub integration.

**Setup:**
1. Download from [cli.github.com](https://cli.github.com)
2. Install and verify:
   ```bash
   gh --version
   ```
3. Authenticate with GitHub:
   ```bash
   gh auth login
   ```
   Follow the prompts to connect to your GitHub account

**Best for:** Streamlined GitHub workflows, creating PRs from terminal, managing issues

### Option 3: GitHub Desktop - Visual Interface

A graphical application for Git and GitHub operations.

**Setup:**
1. Download from [desktop.github.com](https://desktop.github.com)
2. Install and open the application
3. Sign in with your GitHub account
4. Configure your Git settings in Options/Preferences

**Best for:** Visual learners, beginners who prefer GUIs, easy conflict resolution

## Workshop Steps

### Step 1: Fork the Repository

1. Navigate to the original repository on GitHub
2. Click the "Fork" button in the top-right corner
3. This creates a copy of the repository under your GitHub account

### Step 2: Clone Your Fork

**Note:** If you're using GitHub CLI or GitHub Desktop, skip to the [Alternative Workflows](#alternative-workflows) section below for tool-specific instructions.

**Using Git CLI:**
1. On your forked repository page, click the green "Code" button
2. Copy the URL (HTTPS or SSH)
3. Open your terminal/command prompt
4. Navigate to where you want to store the project
5. Run the clone command:

```bash
git clone <your-fork-url>
cd git-101-2026
```

### Step 3: Make Your Changes

1. Open `Program.cs` in your code editor
2. Find the `attendees` array (around line 1-6)
3. Add your name to the list, following the existing format:

```csharp
string[] attendees =
[
    "William Qu",
    "Angus Wong",
    "Your Name Here",  // Add your name!
];
```

4. Save the file

### Step 4: Test Your Changes (Optional)

Run the program to see your name in the list:

```bash
dotnet run
```

### Step 5: Stage Your Changes

**Note:** GitHub CLI and GitHub Desktop users, see [Alternative Workflows](#alternative-workflows) for your specific steps.

**Using Git CLI:**

Stage the file you modified:

```bash
git add Program.cs
```

Or stage all changes:

```bash
git add .
```

Check what's staged:

```bash
git status
```

### Step 6: Commit Your Changes

Create a commit with a descriptive message:

```bash
git commit -m "Add [Your Name] to attendees list"
```

### Step 7: Push to Your Fork

Push your changes to your forked repository on GitHub:

```bash
git push origin main
```

### Step 8: Create a Pull Request

**Note:** GitHub CLI users can create PRs directly from the terminal - see [Alternative Workflows](#alternative-workflows).

**Using Git CLI or GitHub Desktop:**
1. Go to your forked repository on GitHub
2. You should see a prompt saying "Compare & pull request" - click it
3. If not, click "Pull requests" tab, then "New pull request"
4. Add a title and description for your pull request
5. Click "Create pull request"
6. Wait for the maintainer to review and merge your contribution!

## Alternative Workflows

### Using GitHub CLI

If you chose GitHub CLI, here are the equivalent commands:

**Fork the repository:**
```bash
gh repo fork <original-repo-url> --clone
cd git-101-2026
```

**Stage, commit, and push:**
```bash
git add Program.cs
git commit -m "Add [Your Name] to attendees list"
git push origin main
```

**Create a pull request:**
```bash
gh pr create --title "Add [Your Name] to attendees list" --body "Adding my name to the workshop attendees list"
```

**View your pull request:**
```bash
gh pr view --web
```

### Using GitHub Desktop

If you chose GitHub Desktop, follow these steps:

**Fork and clone:**
1. Go to the original repository on GitHub website
2. Click "Fork" button
3. Open GitHub Desktop
4. Go to File → Clone Repository
5. Select your forked repository and choose a local path
6. Click "Clone"

**Make changes and commit:**
1. Make your changes to `Program.cs` in your code editor
2. GitHub Desktop will automatically detect changes
3. Review changes in the "Changes" tab
4. Enter a commit message in the summary field: "Add [Your Name] to attendees list"
5. Click "Commit to main"

**Push and create PR:**
1. Click "Push origin" button to push to your fork
2. Click "Create Pull Request" button
3. GitHub will open in your browser
4. Fill in the PR details and click "Create pull request"

## Useful Commands Reference

### Git CLI Commands

Here are some commands you'll find helpful:

```bash
git status              # Check the status of your working directory
git log                 # View commit history
git diff                # See what changes you've made
git branch              # List branches
git checkout -b <name>  # Create and switch to a new branch
git pull origin main    # Get latest changes from remote
```

### GitHub CLI Commands

If you're using GitHub CLI:

```bash
gh repo view            # View repository details
gh pr list              # List your pull requests
gh pr status            # Check status of your PRs
gh pr checks            # See PR check status
gh issue list           # View issues
gh repo sync            # Sync your fork with upstream
```

### GitHub Desktop

In GitHub Desktop:
- **View changes:** Changes tab shows modified files
- **View history:** History tab shows commits
- **Create branch:** Branch menu → New Branch
- **Switch branches:** Click current branch dropdown
- **Pull changes:** Click "Fetch origin" then "Pull origin"
- **View conflicts:** Conflicted files show in Changes tab with "Open in editor" option

## Troubleshooting

### Merge Conflicts

If someone else added their name in the same location, you might encounter a merge conflict. Don't worry!

**Using Git CLI:**
1. Open the conflicted file in your editor
2. Look for conflict markers (`<<<<<<<`, `=======`, `>>>>>>>`)
3. Edit the file to keep both changes
4. Remove the conflict markers
5. Stage and commit the resolved file:
   ```bash
   git add Program.cs
   git commit -m "Resolve merge conflict"
   ```

**Using GitHub CLI:**
Same as Git CLI - GitHub CLI uses standard Git for conflict resolution

**Using GitHub Desktop:**
1. GitHub Desktop will show conflicted files in the Changes tab
2. Click "Open in [your editor]" on the conflicted file
3. Edit to resolve conflicts and remove markers
4. Save the file
5. Return to GitHub Desktop - it will detect the resolution
6. Click "Commit merge" to complete the resolution

### Need to Update Your Fork?

If the original repository has new changes:

**Using Git CLI:**
```bash
# Add the original repository as a remote (one-time setup)
git remote add upstream <original-repo-url>

# Fetch and merge updates
git fetch upstream
git merge upstream/main
```

**Using GitHub CLI:**
```bash
# Sync your fork with the original repository
gh repo sync
```

**Using GitHub Desktop:**
1. Go to Branch menu → Merge into current branch
2. Select "upstream/main" (you may need to add the upstream remote first)
3. Or use Repository → Repository Settings → Remote to add upstream
4. Then fetch and merge from Branch menu

## Contributing Guidelines

- Use your real name or preferred name
- Be respectful and supportive of other learners

## Questions?

If you get stuck or have questions during the workshop, don't hesitate to ask the workshop facilitators or your fellow attendees. We're all here to learn!

## Additional Resources

- [Git Documentation](https://git-scm.com/doc)
- [GitHub Guides](https://guides.github.com/)
- [Git Cheat Sheet](https://education.github.com/git-cheat-sheet-education.pdf)

---

Happy coding and welcome to the world of version control!