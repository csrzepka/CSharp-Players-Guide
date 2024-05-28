# Testing GitHub Flavored Markdown

This is the start of some text.

Next will be an HTML block test (with styling).

<!-- #region Challenge Description -->
<svg fill="none" viewBox="0 0 600 400" width="600" height="400" xmlns="http://www.w3.org/2000/svg">
  <foreignObject  width="100%" height="100%">
    <div xmlns="http://www.w3.org/1999/xhtml">
      <style>
          .challenge {
              font-family: sans-serif;
              border-top: solid 2px;
              border-bottom: solid 2px;
          }
          .challenge-header {
              display: flex;
              justify-content: space-between;
              font-weight: 700;
              height: 2em;
              align-items: center;
              padding: 0 5px 0;
              background: lightgrey;
          }
          @media (prefers-color-scheme: dark) {
              .challenge-header {
                  background: dimgrey;
              }
          }
          .challenge-body {
              padding: 0 5px 0;
          }
      </style>
      <div class="challenge">
        <div class="challenge-header">
          <span>Boss Battle</span>
          <span>Rock-Paper-Scissors</span>
          <span>150 XP</span>
        </div>
        <div class="challenge-body">
          <p>The first design pedestal requires you to provide an object-oriented design — a set of objects, classes, and how they interact — for the game of Rock-Paper-Scissors, described below:</p>
          <ul>
            <li>Two human players compete against each other.</li>
            <li>Each player picks Rock, Paper, or Scissors.</li>
            <li>Depending on the players' choices, a winner is determined: Rock beats Scissors, Scissors beats Paper, Paper beats Rock. If both players pick the same option, it is a draw.</li>
            <li>The game must display who won the round.</li>
            <li>The game will keep running roudns until the window is closed but must remember the historical record of how many times each player won and how many draws there were.</li>
          </ul>
          <p><strong>Objectives</strong></p>
          <ul>
            <li>Use CRC cards (or a suitable alternative) to outiline the objects and classes that may be needed to make the game of Rock-Paper-Scissors. <strong>You do not need to create this full game; just come up with a potential design as a starting point.</strong></li>
          </ul>
        </div>
      </div>
    </div>
  </foreignObject>
</svg>
<!-- #endregion -->

<br>

This is text after the HTML block.
