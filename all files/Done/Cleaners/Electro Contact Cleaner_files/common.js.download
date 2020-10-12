$(function () {
    //Responsive Menu
    var header = $(".start-style");
    $(window).scroll(function () {
        var scroll = $(window).scrollTop();

        if (scroll >= 10) {
            header.removeClass('start-style').addClass("scroll-on");
        } else {
            header.removeClass("scroll-on").addClass('start-style');
        }
    });
    $('body').on('mouseenter mouseleave', '.nav-item', function (e) {
        if ($(window).width() > 750) {
            var _d = $(e.target).closest('.nav-item');
            _d.addClass('show');
            setTimeout(function () {
                _d[_d.is(':hover') ? 'addClass' : 'removeClass']('show');
            }, 1);
        }
    });

    $(document).mouseup(function(e)
    {
        var container = $("#hdTuto_search");

        // if the target of the click isn't the container nor a descendant of the container
        if (!container.is(e.target) && container.has(e.target).length === 0)
        {
            container.hide();
        }
    });
    //Responsive Menu
});

$(document).ready(function () {
    $('body.hero-anime').removeClass('hero-anime');

    //header search
    $('#querystr').keyup(function (e) {
        e.preventDefault();
        var form = $('#hdTutoForm').serialize();
        $.ajax({
            type: 'POST',
            url: '/search',
            data: form,
            dataType: 'json',
            success: function (response) {
                if (response.error) {
                    $('#hdTuto_search').hide();
                }
                else {
                    $('#hdTuto_search').show().html(response.data);
                }
            }
        });

    });
    //header search

    //Home slider

    $('.home-slider').owlCarousel({
        loop:false,
        margin:10,
        nav:false,
        responsive:{
            0:{
                items:1
            },
            600:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });
    $('.brands-slider').owlCarousel({
        loop:true,
        margin:10,
        nav:false,
        dots:false,
        autoplay:true,
        autoplayTimeout:2000,
        autoplayHoverPause:false,
        responsive:{
            0:{
                items:2
            },
            600:{
                items:3
            },
            1000:{
                items:5
            }
        }
    });
    //Home Slider
});
