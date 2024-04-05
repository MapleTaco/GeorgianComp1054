const tabpanels = document.querySelectorAll("ul[role='tablist']");

const tabs = document.querySelectorAll("div[role='tabpanel']");
console.log("tabs");

tabpanels.forEach((tab) => {
    tab.addEventListener("click", closeOpenTabs);
});

function closeOpenTabs() {
    console.log("poop");
    tabpanels.forEach((tab) => {

		let tab = summary.parentNode;

		if (tab != this.parentNode) {
            console.log("oof");
		}
	});
}