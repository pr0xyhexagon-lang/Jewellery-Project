"use strict";

document.addEventListener("DOMContentLoaded", function () {

    const header = document.querySelector(".site-header");
    const revealElements = document.querySelectorAll(".reveal");
    const wishlistButtons = document.querySelectorAll(".product-wishlist");

    const navigationElement =
        document.getElementById("luxuryNavigation");

    const directNavigationLinks =
        document.querySelectorAll(
            "#luxuryNavigation a.nav-link"
        );

    const megaMenuItems =
        document.querySelectorAll(".mega-menu-item");

    const megaMenuToggles =
        document.querySelectorAll(".mega-menu-toggle");

    const megaMenuLinks =
        document.querySelectorAll(".mega-menu a");

    const newsletterForm =
        document.getElementById("newsletterForm");

    const newsletterMessage =
        document.getElementById("newsletterMessage");

    const currentYear =
        document.getElementById("currentYear");

    const testimonialTrack =
        document.getElementById("testimonialTrack");

    const testimonialPrevious =
        document.getElementById("testimonialPrevious");

    const testimonialNext =
        document.getElementById("testimonialNext");


    /*
     * Current year
     */
    if (currentYear) {
        currentYear.textContent =
            new Date().getFullYear().toString();
    }


    /*
     * Header scroll effect
     */
    function updateHeader() {

        if (!header) {
            return;
        }

        if (window.scrollY > 20) {
            header.classList.add("is-scrolled");
        } else {
            header.classList.remove("is-scrolled");
        }

    }

    updateHeader();

    window.addEventListener(
        "scroll",
        updateHeader,
        {
            passive: true
        }
    );


    /*
     * Reveal animation
     */
    if ("IntersectionObserver" in window) {

        const revealObserver =
            new IntersectionObserver(
                function (entries, observer) {

                    entries.forEach(function (entry) {

                        if (!entry.isIntersecting) {
                            return;
                        }

                        entry.target.classList.add(
                            "is-visible"
                        );

                        observer.unobserve(
                            entry.target
                        );

                    });

                },
                {
                    threshold: 0.12,
                    rootMargin:
                        "0px 0px -45px 0px"
                }
            );

        revealElements.forEach(function (element) {
            revealObserver.observe(element);
        });

    } else {

        revealElements.forEach(function (element) {
            element.classList.add("is-visible");
        });

    }


    /*
     * Wishlist buttons
     */
    wishlistButtons.forEach(function (button) {

        button.addEventListener(
            "click",
            function () {

                button.classList.toggle("is-active");

                const icon =
                    button.querySelector("i");

                if (!icon) {
                    return;
                }

                if (
                    button.classList.contains("is-active")
                ) {

                    icon.classList.remove("bi-heart");
                    icon.classList.add("bi-heart-fill");

                    button.setAttribute(
                        "aria-label",
                        "Remove from wishlist"
                    );

                } else {

                    icon.classList.remove("bi-heart-fill");
                    icon.classList.add("bi-heart");

                    button.setAttribute(
                        "aria-label",
                        "Add to wishlist"
                    );

                }

            }
        );

    });


    /*
     * Mega menu helpers
     */
    function closeAllMegaMenus(exceptionItem) {

        megaMenuItems.forEach(function (item) {

            if (item === exceptionItem) {
                return;
            }

            item.classList.remove("is-open");

            const toggle =
                item.querySelector(".mega-menu-toggle");

            if (toggle) {
                toggle.setAttribute(
                    "aria-expanded",
                    "false"
                );
            }

        });

    }


    /*
     * Open mega menus by button tap/click
     */
    megaMenuToggles.forEach(function (toggle) {

        toggle.addEventListener(
            "click",
            function (event) {

                event.preventDefault();

                const menuItem =
                    toggle.closest(".mega-menu-item");

                if (!menuItem) {
                    return;
                }

                const shouldOpen =
                    !menuItem.classList.contains(
                        "is-open"
                    );

                closeAllMegaMenus(menuItem);

                menuItem.classList.toggle(
                    "is-open",
                    shouldOpen
                );

                toggle.setAttribute(
                    "aria-expanded",
                    shouldOpen
                        ? "true"
                        : "false"
                );

            }
        );

    });


    /*
     * Desktop hover:
     * close any menu previously opened by click
     */
    megaMenuItems.forEach(function (item) {

        item.addEventListener(
            "mouseenter",
            function () {

                if (window.innerWidth < 992) {
                    return;
                }

                closeAllMegaMenus(item);

            }
        );

    });


    /*
     * Close menu when clicking outside
     */
    document.addEventListener(
        "click",
        function (event) {

            if (
                event.target.closest(".mega-menu-item")
            ) {
                return;
            }

            closeAllMegaMenus();

        }
    );


    /*
     * Escape key closes menus
     */
    document.addEventListener(
        "keydown",
        function (event) {

            if (event.key !== "Escape") {
                return;
            }

            closeAllMegaMenus();

        }
    );


    /*
     * Placeholder links:
     * pages will be connected later
     */
    megaMenuLinks.forEach(function (link) {

        link.addEventListener(
            "click",
            function (event) {

                if (
                    link.dataset.placeholder === "true"
                ) {

                    event.preventDefault();
                    return;

                }

                closeAllMegaMenus();

                if (
                    window.innerWidth < 992 &&
                    navigationElement &&
                    typeof bootstrap !== "undefined"
                ) {

                    const collapseInstance =
                        bootstrap.Collapse
                            .getOrCreateInstance(
                                navigationElement,
                                {
                                    toggle: false
                                }
                            );

                    collapseInstance.hide();

                }

            }
        );

    });


    /*
     * Close mobile navigation after
     * choosing a direct menu link
     */
    directNavigationLinks.forEach(function (link) {

        link.addEventListener(
            "click",
            function () {

                closeAllMegaMenus();

                if (
                    window.innerWidth >= 992 ||
                    !navigationElement ||
                    typeof bootstrap === "undefined"
                ) {
                    return;
                }

                const collapseInstance =
                    bootstrap.Collapse
                        .getOrCreateInstance(
                            navigationElement,
                            {
                                toggle: false
                            }
                        );

                collapseInstance.hide();

            }
        );

    });


    /*
     * Reset mega menus when resizing
     */
    window.addEventListener(
        "resize",
        function () {

            closeAllMegaMenus();

        }
    );


    /*
     * Testimonial slider
     */
    function testimonialScrollDistance() {

        if (!testimonialTrack) {
            return 0;
        }

        const firstCard =
            testimonialTrack.querySelector(
                ".testimonial-card"
            );

        if (!firstCard) {
            return testimonialTrack.clientWidth;
        }

        const trackStyles =
            window.getComputedStyle(
                testimonialTrack
            );

        const gap =
            parseFloat(
                trackStyles.columnGap ||
                trackStyles.gap ||
                "0"
            );

        return firstCard.offsetWidth + gap;

    }

    if (
        testimonialTrack &&
        testimonialPrevious
    ) {

        testimonialPrevious.addEventListener(
            "click",
            function () {

                testimonialTrack.scrollBy({
                    left:
                        -testimonialScrollDistance(),
                    behavior: "smooth"
                });

            }
        );

    }

    if (
        testimonialTrack &&
        testimonialNext
    ) {

        testimonialNext.addEventListener(
            "click",
            function () {

                testimonialTrack.scrollBy({
                    left:
                        testimonialScrollDistance(),
                    behavior: "smooth"
                });

            }
        );

    }


    /*
     * Newsletter demonstration
     */
    if (
        newsletterForm &&
        newsletterMessage
    ) {

        newsletterForm.addEventListener(
            "submit",
            function (event) {

                event.preventDefault();

                const emailInput =
                    newsletterForm.querySelector(
                        'input[type="email"]'
                    );

                if (
                    !emailInput ||
                    !emailInput.checkValidity()
                ) {

                    newsletterMessage.textContent =
                        "Please enter a valid email address.";

                    return;

                }

                newsletterMessage.textContent =
                    "Thank you for joining the Luxe List.";

                newsletterForm.reset();

            }
        );

    }

});