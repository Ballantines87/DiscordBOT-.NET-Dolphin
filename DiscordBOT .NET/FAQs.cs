using System.Text;

namespace DiscordBOT_.NET
{
    public static class FAQs
    {
       
        /*Hi Paul, can we test it in this way:

        Have three categories of questions they can choose

        1. Manta Signer
        2. Dolphin App
        3. Operating Systems
        4. Incentive Campaign

        When they copy paste these to the bot, they can get a batch of Q&A related to these
        So they don't have to copy paste the questions exactly but these options that are way shorter*/

        public static string DescribingMantaSignerFAQs()
        {
            var sb = new StringBuilder();

            sb.AppendLine("❗ ***Please check that you've installed the LATEST version of the Manta Signer. Check that it's running, and that you're logged in.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❗ ***When creating your Signer account, please make sure your input password is AT LEAST 8 characters to create a new private account in signer.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❓ ***The 'To Private' button on the dolphin testnet is NOT working.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ Please try reloading the page at https://app.dolphin.manta.network/#/transact. \n" +
                "Click on the 'To Private' button again once you see a number next to BOTH 'Balance' fields. Wait patiently until the three dots in the private section ... disappear.");
            sb.AppendLine("");
            sb.AppendLine("Please note that our testnet is currently overwhelmingly popular, and many transactions are trying to go through the network simultaneously.\n\n" +
                "So if you're still experiencing:");
            sb.AppendLine("");
            sb.AppendLine("I. Public to private tx NOT activating");
            sb.AppendLine("II. Polkadot.js wallet NOT showing");
            sb.AppendLine("III. LONG periods for transactions");
            sb.AppendLine("");
            sb.AppendLine("Please wait and try again later!");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❓ ***On Windows 10, occasionally the installer will fail due to WebView2 not installing correctly.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ If this happens, you can try downloading and installing WebView2 runtime directly from https://developer.microsoft.com/en-us/microsoft-edge/webview2/#download-section");
            sb.AppendLine("");
            sb.AppendLine("Please note that it still might not work.\nThe team is aware of the Windows issue and is currently working on a fix; we'll update the community on the new updates.");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❓ ***How can I recover private tokens if I forgot my Signer password?***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ We will add the account recovery feature to the Signer soon.");
            sb.AppendLine("");
            sb.AppendLine("In the meanwhile, what you can do is trying to remove your private account data completely and set up a new account.\n" +
                "To do that, you should remove the following files:");
            sb.AppendLine("");
            sb.AppendLine("On MacOS: macOS: ~/Library/Application Support/manta-signer/");
            sb.AppendLine("Linux: ~/.config/manta-signer/");
            sb.AppendLine("Windows: ~/AppData/Roaming/manta-signer/");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("-----");

            sb.AppendLine("➡️ *If all these checks pass and you still can't send transactions, please let us know on Discord in the #dolphin-testnet channel so that we can improve Dolphin!*\n\n" +
                "➡️ *You can also help us with valuable feedback via the Dolphin Testnet Bug Report Form here: https://forms.gle/dBGq2NXXNGLW6PdP8*");
            sb.AppendLine("-----");

            string mantaSignerString = sb.ToString();
            return mantaSignerString;
        }



        public static string DescribingDolphinWebAppFAQs()
        {
            var sb = new StringBuilder();

            sb.AppendLine("❗ ***Check that your shields are DOWN if you are using Brave browser.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❗ ***Check that you are connected to a node ('Dolphin' by default) and that your internet connection is stable.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❗ ***Check that you have some public DOL in order to pay fees.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❗ ***If you see a delay in the transaction, check the polkadot.js wallet metadata if it needs to be updated." +
                "\n See the link at https://polkadot.js.org/apps/#/settings/metadata for any metadata updates.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("");


            sb.AppendLine("❓ ***I have followed the Twitter channels, but Gleam is NOT showing the ☑️ checkmark.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ First, please make sure the email account you're logged in on Gleam is the same as the account you were using when you filled the form.\n\n" +
                "If not, you'll have to fill out the form again using the same email/account (both on Gleam and the Google Form).\n\n" +
                "After that, please clean your cache, reload the page and try again.");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❓ ***I can’t find Calamari Network on Polkadot.Js***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ 1. To get the Calamari address, you should follow the below-mentioned steps:");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("1.1 click on polkadot.js extension > Click on three vertical dots as mentioned in the image > Select Calamari Parachain.");
            sb.AppendLine("");
            sb.AppendLine("If you still don't see the 'Calamari' parachain option, then please visit this URL https://polkadot.js.org/apps/?rpc=wss%3A%2F%2Fcalamari-rpc.dwellir.com#/explorer.");
            sb.AppendLine("");
            sb.AppendLine("2. Go to settings > Metadata > Update Metadata");
            sb.AppendLine("");
            sb.AppendLine("Finally, please follow steps mentioned in step 1.1");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("-----");

            sb.AppendLine("➡️ *If all these checks pass and you still can't send transactions, please let us know on Discord in the #dolphin-testnet channel so that we can improve Dolphin!*\n\n" +
                "➡️ *You can also help us with valuable feedback via the Dolphin Testnet Bug Report Form here: https://forms.gle/dBGq2NXXNGLW6PdP8*");
            sb.AppendLine("-----");

            string dolphinAppString = sb.ToString();
            return dolphinAppString;
        }


        public static string DescribingIncentivizedTestnetFAQs()
        {
            var sb = new StringBuilder();

            sb.AppendLine("❓ ***Check that the polkadot.js browser extension is installed, and has permission to connect to the Dolphin web app.***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ Click on your Polkadot.Js extension --> click on the ⚙️ icon on the top-right corner --> then click on 'Manage Website Access' --> check that 'https://app.dolphin.manta.network' is set to 'Allowed'.");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❓ ***Which address should I enter in the form when asked 'enter your private transfer transaction ID to this wallet address 2LTk1QjGptbMdHUVKYD6RzRuWv5hefTd1SrcZsS9o1ZEmvvppZmMfE36ChcEve7azJHXvrx5qptmBzDykaenTmTG'?***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ Go to https://dolphin.subscan.io/, search your public wallet address of the dolphin app, find the extrinsic hash of your private transfer to the 2LTk1QjGptbMdHUVKYD6RzRuWv5hefTd1SrcZsS9o1ZEmvvppZmMfE36ChcEve7azJHXvrx5qptmBzDykaenTmTG.\n\n" +
                "Then copy/paste the extrinsic hash that you've found into the form field.");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❓ ***Is the Gleam form closed?***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ No, it's not. If you're having issues loading it, please try clearing your browser's cache. Then check again the link at https://gleam.io/ye0bg/dolphin-testnet-v2-airdrop.");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❓ ***How do I participate in the testnet?***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ There is a very thorough GUIDE, please follow the steps at https://mantanetwork.medium.com/manta-network-testnet-v2-walkthrough-28837d7bbba7. \n\n" +
                "You can also check the Dolphin V2 Resources & Official Announcement at https://discord.com/channels/795390654628102165/795403612107964416/978712997117698159");
            sb.AppendLine("");
            sb.AppendLine("");

            sb.AppendLine("❓ ***For how long will the incentivized testnet campaign run?***");
            sb.AppendLine("-----");
            sb.AppendLine("");
            sb.AppendLine("✅ The incentivized testnet campaign will run until the Calamari mainnet launch.");

            string incentivizedTestnetString = sb.ToString();
            return incentivizedTestnetString;
        }
    }
}
