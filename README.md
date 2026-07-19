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
  - [Connecting to Github via SSH [Git CLI]](#connecting-to-your-git-repo-via-ssh-using-git-cli)
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
- [Git](https://git-scm.com/install) installed on your computer (**required for all options**)
  - **Note:** Git CLI must be installed first, regardless of which Git tool you choose. GitHub Desktop is just a GUI wrapper around Git and requires Git to be already installed.
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
4. **Set up authentication for Git CLI:** If you're using HTTPS URLs to clone/push, you'll need a Personal Access Token (PAT). [Click here to create one](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#creating-a-personal-access-token-classic)
   - Go to GitHub Settings → Developer settings → Personal access tokens → Tokens (classic)
   - Generate a new token with `repo` scope
   - Keep the token handy for later use!
   ![github-pat-howto](https://github.com/user-attachments/assets/66e78b13-2750-47bb-b062-ad5c9b6d2cdc)

**Best for:** Learning Git fundamentals, available everywhere, most documentation uses this. Also supports complex operations that GUI tools sometimes don't support

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
    ...
    "Your Name Here",  // Add your name here, and leave a trailing comma!
    // Add your name above this line! (Do not delete this)
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
git push
```

**First time using Git CLI?** You'll be prompted for authentication:
- Enter your **GitHub username**
- Enter your **Personal Access Token** (the one you created earlier)
- Press Enter to continue

<img width="568" height="217" alt="Screenshot 2026-03-16 at 11 37 50 PM" src="https://github.com/user-attachments/assets/eec1fc31-f7d3-4b25-8cbe-c4ee7c81acb4" />


**Note:** If you get an error saying "remote: Invalid username or token. Password authentication is not supported for Git operations.", don't worry! Your token may have expired. Just run `git push` again - you'll be asked for your credentials again. [Create a new PAT](#option-1-git-cli-command-line-interface---recommended-for-learning) and paste it in.

<img width="567" height="154" alt="Screenshot 2026-03-17 at 12 09 18 AM" src="https://github.com/user-attachments/assets/561f3866-ba46-4e76-a384-2dc937778889" />


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

### Connecting to your Git Repo (via SSH) using Git CLI

- [Check for key](#check-for-key)
` [Generate SSH key](#generate-ssh-key)
- [Adding SSH key to Github account](#adding-ssh-key-to-github-account)
- [Stuck on HTTPS?](#stuck-on-https)

Due to github removing suppport for passowrd authentication, it is recommended to use SSH to connect to your repos. Note: to PR (pull request), you will have to either use the Github CLI or Github Desktop, or from the Github website. Most of the information regarding generating keys and checking keys here is availbale to read at [Connecting to Github with SSH](https://docs.github.com/en/authentication/connecting-to-github-with-ssh). Make sure you've configured your user.name and user.email, information [here](#option-1-git-cli-command-line-interface---recommended-for-learning)

Lets get started.
#### Check for key
First check for a SSH key incase you've previously made one at the DEFAULT file location:
```bash
ls -al ~/.ssh
```

This checks the DEFAULT location where your keys are held. Generally the supported filenames of supported public keys for Github (according to Github) are one of the following:

* *id\_rsa.pub*

* *id\_ecdsa.pub*

* *id\_ed25519.pub*

.pub means it is a public key.

**DO NOT SHARE YOUR PRIVATE KEYS!!**


### Generate SSH key

Paste the text below, replacing the email used in the example with your GitHub email address.

To generate up a SSH key
```bash
ssh-keygen -t ed25519 -C "your_email@example.com"
```
**Note**
> If you are using a legacy system that doesn't support the Ed25519 algorithm, use:
> ```shell
> ssh-keygen -t rsa -b 4096 -C "your_email@example.com"
> ```

This creates a new SSH key, using the provided email as a label.


> When you're prompted to "Enter a file in which to save the key", you can press Enter to accept the default file location, which can be [checked](#check-for-key) or you can supply the default type location (make sure you remember where it is).

Another prompt will be given to type a secure [passphrase](https://docs.github.com/en/authentication/connecting-to-github-with-ssh/working-with-ssh-key-passphrases). 
> Enter passphrase (empty for no passphrase): [Type a passphrase]
> Enter same passphrase again: [Type passphrase again]

** Congratulations you have now created a SSH key! **

#### Adding SSH key to Github account

After the creation of your SSH key, you must get the contents of your public key.

```bash
$ cat ~/.ssh/id_ed25519.pub
# Then select and copy the contents of the id_ed25519.pub file
# displayed in the terminal to your clipboard
```

Beware of using `cat` on files, using `cat` for something like a public key is fine (because it's meant to be shared). It will not be explained here, but it is highly recommended to look into the reasons behind it.



1. In the upper-right corner of any page on GitHub, click your profile picture, then click Settings.

2. In the "Access" section of the sidebar, click SSH and GPG keys.

3. Click New SSH key or Add SSH key.

4. In the "Title" field, add a descriptive label for the new key. For example, if you're using a personal laptop, you might call this key "Personal laptop".

5. Select the type of key, either authentication or signing. For more information about commit signing, see About commit signature verification.

6. In the "Key" field, paste your public key.

7. Click Add SSH key.

8. If prompted, confirm access to your account on GitHub. 

** You now have added your SSH public key to your github account, and can start [staging](#step-5-stage-your-changes), [committing](#step-6-commit-your-changes) and [push](#step-7-push-to-your-fork)**

** When pushing, you will have to supply your passphrase when using SSH, make sure you remember your passphrase otherwise you might have to restart the proccess again **


#### Stuck on HTTPS?

If you're still using HTTPS and want to change it so that you are using SSH, do the following:

1. We are going to check what type of url (which is the remote repository, meaning outside your computer) the local git repo (the repository that is on your computer right now) is connected to. Shows the remote repositories connected to your local Git repo, with their URLs. Enter this command to check where and what type of connection it is:
 ```bash
 git remote -v
 ```

This is what your output looks like when you have a HTTPS connection:
``` bash 
origin  https://github.com/your_username/repo-name.git (fetch)
origin  https://github.com/your_username/repo-name.git (push)
```


2. This is what your output looks like when you have a SSH connection:
```bash
origin  git@github.com:your_username/repo-name.git (fetch)
origin  git@github.com:your_username/repo-name.git (push)
```

To change it to SSH (or vis vera), do the following:

```bash
git remote remove origin      # removes the origin of the remote repo

git remote add origin ( the ssh address you copied from the green CODE button from the repo page )    #adds the new origin address

# then you can push your code

git push -u origin main       # the -u means it's set upstream, also this command assumes you've already staged and committed your changes
```

** That's all! **


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
git push
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
# Basic workflow
git add <filename>              # Stage a file for commit (replace <filename> with the file you want to commit)
git add .                       # Stage all changes
git commit -m "message"         # Create a commit with message
git push                        # Push to remote repository
git pull <remote> <branch>      # Pull latest changes from remote (<remote> = remote alias like "origin", <branch> = branch name)

# View and manage
git status                      # Check the status of your working directory
git log                         # View commit history
git diff                        # See what changes you've made
git branch                      # List branches
git checkout -b <branch>          # Create and switch to a new branch
git checkout <branch>             # Switch to an existing branch
git checkout <commit>             # Switch to a specific commit (replace <commit> with commit hash)
git remote -v                     # View your remotes (origin, upstream)

# Update your fork
git fetch <remote>               # Get latest changes from remote repo (e.g., upstream)
git merge <remote>/<branch>      # Merge changes into your current branch (e.g., upstream/main)

# Undo mistakes (use carefully!)
git reset --soft HEAD~1         # Undo last 1 commit (keeps staged changes)
git stash                       # Temporarily save uncommitted changes (removes them from working directory, stores on stack)
git stash pop                   # Restore stashed changes back to working directory and remove from stack
```

### GitHub CLI Commands

If you're using GitHub CLI, here are some commands:

```bash
# Fork and clone
gh repo fork <repo> --clone      # Fork a repo and clone it locally (replace <repo> with repo URL)

# Pull requests
gh pr create                     # Create a pull request
gh pr list                       # List your pull requests
gh pr status                     # Check status of your PRs
gh pr view --web                 # View a PR in the browser

# Issues
gh issue list                    # View issues
gh issue create                  # Create a new issue

# Repository management
gh repo view                     # View repository details
gh repo sync                     # Sync your fork with upstream
```

### GitHub Desktop

In GitHub Desktop, you can manage your workflow visually:

- **View changes:** Changes tab shows modified files and their status
- **View history:** History tab displays all your commits with details
- **Create branch:** Branch menu → New Branch (or use the branch dropdown)
- **Switch branches:** Click current branch dropdown to select a branch
- **Pull changes:** File menu → Pull, or click "Fetch origin" then "Pull origin" button (pulls from your fork to local)
- **Push changes:** File menu → Push, or click "Push origin" button (pushes from local to your fork only)
- **View conflicts:** Conflicted files appear in Changes tab with "Open in editor" option

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

**Resolve on GitHub Website**
You can also resolve conflicts directly in your browser:
1. Go to the Pull Request page on GitHub
2. Scroll down to see the conflict markers in the file diff
3. Use GitHub's inline editor to resolve each conflict
4. Click "Keep both version" if you want to merge both changes
5. Or choose one version (yours or theirs) as needed
6. After resolving all conflicts, click "Mark conversation as resolved"
7. Commit the changes from the Pull Request page

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

**Using GitHub Website:**
1. Go to your fork on GitHub
2. Click the green "Sync fork" button (if available)
3. After syncing, click "Update Branch" button that appears

## Contributing Guidelines

- Use your real name or preferred name
- Be respectful and supportive of other learners
- Join our [Code Network Discord](https://discord.gg/RPGhVfJUD8) for support and discussions

## Questions?

If you get stuck or have questions during the workshop, don't hesitate to ask the workshop facilitators or your fellow attendees. We're all here to learn!

## Additional Resources

- [Git Documentation](https://git-scm.com/doc)
- [GitHub Guides](https://guides.github.com/)
- [Git Cheat Sheet](https://education.github.com/git-cheat-sheet-education.pdf)

---

Happy coding and welcome to the world of version control!
