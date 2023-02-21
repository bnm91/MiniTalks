BLUE_BACK='\033[0;44m'
GREEN_BACK='\033[0;42m'
RED_BACK='\033[0;41m'
NO_BACK='\033[0m'

print_tutorial_text() {
    echo -e "${BLUE_BACK}$1${NO_BACK}"
}

press_any_key() {
    echo -e "${RED_BACK}Press any key to continue${NO_BACK}"
    read
}

print_tutorial_text "Welcome to the patching demo!
Blue background text like this is instructional
Red background text prompts you for input
Default text is output from git!

Let's begin"

mkdir patching; cd ./patching
git init
print_tutorial_text "I've created new git repo for you"
press_any_key
echo ""

echo "Hello world." > greeting
git add .
git commit -m "initial version"
print_tutorial_text "I've staged and commited the initial version
Here's what it looks like: "
cat greeting
press_any_key
echo ""

print_tutorial_text "Now you update greeting to read as follows: "
echo "Hello world!

My name is git."
echo ""
print_tutorial_text "Don't move on until this is done"
press_any_key
echo ""

print_tutorial_text "I'm about to run git add --patch.
You will be presented with the changes to greeting
and prompted with options to stage them.
Select 'e' to edit this hunk
Right now we only want to stage the change from '.' to '!'
So remove the '+' lines other than that"
echo ""
RED='\033[0;31m'
NC='\033[0m' # No Color
GREEN='\033[0;32m'
print_tutorial_text "Your edited hunk should appear as follows"
echo -e "${RED}- Hello world."
echo -e "${GREEN}+ Hello world!${NC}"
echo ""
print_tutorial_text "Pro Tip: If using vi (default editor), when you finish editing, press ESC then ':wq' to save"
press_any_key
git add --patch
echo ""

print_tutorial_text "Now I'll run git status to show what we've done"
press_any_key
echo ""
git status
echo ""
press_any_key
print_tutorial_text "Notice we have both staged and unstaged changes in greeting
Our patch with only the punctuation change is ready for commit"
echo ""

print_tutorial_text "Next I'll will make that commit"
press_any_key
echo ""
git commit -m 'Make greeting excited'

print_tutorial_text "Look at the status now"
press_any_key
echo ""
git status

print_tutorial_text "Great. The punctuation change is committed,
and our other change is still in the working directory.
Let's add it as a separate commit"
press_any_key
echo ""
git add greeting
git commit -m "Adding introduction"
press_any_key
echo ""

print_tutorial_text "Great! Let's check out the log which will show all 3 commits"
press_any_key
echo ""
git log
press_any_key
echo ""

print_tutorial_text "Demo complete!"