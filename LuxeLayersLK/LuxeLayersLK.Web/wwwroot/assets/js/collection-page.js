"use strict";

document.addEventListener("DOMContentLoaded", function () {

    const grid = document.getElementById("collectionProductGrid");
    const cards = Array.from(
        document.querySelectorAll(".collection-product-card")
    );

    const checkboxes = Array.from(
        document.querySelectorAll("[data-filter-group]")
    );

    const sortSelect = document.getElementById("collectionSort");
    const clearButton = document.getElementById("clearCollectionFilters");
    const resultCount = document.getElementById("collectionResultCount");
    const noResults = document.getElementById("collectionNoResults");
    const loadMoreButton = document.getElementById("collectionLoadMore");

    if (!grid || cards.length === 0) {
        return;
    }

    let visibleLimit = 8;

    function selectedValues(groupName) {

        return checkboxes
            .filter(function (checkbox) {
                return (
                    checkbox.dataset.filterGroup === groupName &&
                    checkbox.checked
                );
            })
            .map(function (checkbox) {
                return checkbox.value;
            });

    }

    function matchesPrice(price, selectedPrices) {

        if (selectedPrices.length === 0) {
            return true;
        }

        return selectedPrices.some(function (range) {

            if (range === "under-10000") {
                return price < 10000;
            }

            if (range === "10000-25000") {
                return price >= 10000 && price <= 25000;
            }

            if (range === "above-25000") {
                return price > 25000;
            }

            return true;

        });

    }

    function applyCollectionFilters() {

        const materials = selectedValues("material");
        const stones = selectedValues("stone");
        const sizes = selectedValues("size");
        const prices = selectedValues("price");

        let filteredCards = cards.filter(function (card) {

            const cardSizes = card.dataset.sizes
                .split(",")
                .map(function (value) {
                    return value.trim();
                });

            const cardPrice = Number(card.dataset.price);

            const materialMatches =
                materials.length === 0 ||
                materials.includes(card.dataset.material);

            const stoneMatches =
                stones.length === 0 ||
                stones.includes(card.dataset.stone);

            const sizeMatches =
                sizes.length === 0 ||
                sizes.some(function (size) {
                    return cardSizes.includes(size);
                });

            const priceMatches =
                matchesPrice(cardPrice, prices);

            return (
                materialMatches &&
                stoneMatches &&
                sizeMatches &&
                priceMatches
            );

        });

        const sortValue = sortSelect
            ? sortSelect.value
            : "featured";

        filteredCards.sort(function (firstCard, secondCard) {

            if (sortValue === "price-low") {
                return (
                    Number(firstCard.dataset.price) -
                    Number(secondCard.dataset.price)
                );
            }

            if (sortValue === "price-high") {
                return (
                    Number(secondCard.dataset.price) -
                    Number(firstCard.dataset.price)
                );
            }

            if (sortValue === "newest") {
                return (
                    Number(firstCard.dataset.newest) -
                    Number(secondCard.dataset.newest)
                );
            }

            return (
                Number(firstCard.dataset.featured) -
                Number(secondCard.dataset.featured)
            );

        });

        cards.forEach(function (card) {
            card.classList.add("is-hidden");
        });

        filteredCards.forEach(function (card) {
            grid.appendChild(card);
        });

        filteredCards
            .slice(0, visibleLimit)
            .forEach(function (card) {
                card.classList.remove("is-hidden");
            });

        if (resultCount) {

            const word =
                filteredCards.length === 1
                    ? "ring"
                    : "rings";

            resultCount.textContent =
                filteredCards.length + " " + word;

        }

        if (noResults) {
            noResults.hidden =
                filteredCards.length !== 0;
        }

        if (loadMoreButton) {
            loadMoreButton.hidden =
                filteredCards.length <= visibleLimit;
        }

    }

    checkboxes.forEach(function (checkbox) {

        checkbox.addEventListener("change", function () {
            visibleLimit = 8;
            applyCollectionFilters();
        });

    });

    if (sortSelect) {

        sortSelect.addEventListener("change", function () {
            visibleLimit = 8;
            applyCollectionFilters();
        });

    }

    if (clearButton) {

        clearButton.addEventListener("click", function () {

            checkboxes.forEach(function (checkbox) {
                checkbox.checked = false;
            });

            if (sortSelect) {
                sortSelect.value = "featured";
            }

            visibleLimit = 8;
            applyCollectionFilters();

        });

    }

    if (loadMoreButton) {

        loadMoreButton.addEventListener("click", function () {
            visibleLimit += 4;
            applyCollectionFilters();
        });

    }

    document.addEventListener("click", function (event) {

        document
            .querySelectorAll(".collection-filter[open]")
            .forEach(function (filter) {

                if (!filter.contains(event.target)) {
                    filter.removeAttribute("open");
                }

            });

    });

    applyCollectionFilters();

});