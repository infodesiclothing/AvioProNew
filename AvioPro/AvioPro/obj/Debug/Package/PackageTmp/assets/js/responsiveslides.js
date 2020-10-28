$(function () {
  $(".rslides").responsiveSlides({
    auto: true,
    // Boolean: Animate automatically, true or false

    speed: 500,
    // Integer: Speed of the transition, in milliseconds

    timeout: 5000,
    //Integer: Time between slide transitions, in milliseconds

    pager: false,
    // Boolean: Show pager, true or false

    nav: true,
    // Boolean: Show navigation, true or false

    random: false,
    //Boolean: Randomize the order of the slides, true or false

    pause: false,
    // Boolean: Pause on hover, true or false

    pauseControls: false,
    // Boolean: Pause when hovering controls,    true or false

    prevText: "Previous",
    // String: Text for the "previous" button

    nextText: "Next",
    // String:Text for the "next" button

    namespace: "rslides",
    // String: Change the default  namespace used
  });
});
